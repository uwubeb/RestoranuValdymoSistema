using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using RestoranuValdymoSistema.Data.Constants;
using RestoranuValdymoSistema.Data.Contracts.User;
using RestoranuValdymoSistema.Data.Exceptions;
using RestoranuValdymoSistema.Data.Models;
using RestoranuValdymoSistema.Infrastructure.Repositories;

namespace RestoranuValdymoSistema.Services;

public class AuthService : IAuthService
{
    private readonly IRepository<User> _userRepository;
    private readonly IRestaurantRepository _restaurantRepository;
    private readonly IConfiguration _configuration;

    public AuthService(IRepository<User> userRepository, IConfiguration configuration, IRestaurantRepository restaurantRepository)
    {
        _userRepository = userRepository;
        _configuration = configuration;
        _restaurantRepository = restaurantRepository;
    }


    public async Task<User> Register(CreateUserRequest request)
    {
        CreatePasswordHash(request.Password, out var passwordHash, out var passwordSalt);

        if (request.Role.ToLower() != RolesConstants.SuperAdmin && request.Role.ToLower() != RolesConstants.Admin && request.Role.ToLower() != RolesConstants.User && request.Role.ToLower() != RolesConstants.Guest)
        {
            throw new AppException(ExceptionConstants.InvalidRole);
        }
        var user = new User
        {
            Username = request.Username,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt,
            Role = request.Role.ToLower(),
            Name = request.Name,
            Surname = request.Surname,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            Restaurants = new List<Restaurant>()
        };
        
        if (await _userRepository.Exists(x => x.Username == user.Username))
            throw new AppException("User already exists");

        await _userRepository.Create(user);
        
        // add restaurants to user
        if (request.RestaurantIds.Any())
        {
            foreach (var restaurantId in request.RestaurantIds)
            {
                var restaurant = await _restaurantRepository.Get(restaurantId);
                //user.Restaurants.ToList().Add(restaurant);
                restaurant.Users.Add(user);
               await _restaurantRepository.Update(restaurant);
            }
        }

       
        return user; 
    }

    public async Task<string> Login(LoginRequest request)
    {
        var user = (await _userRepository.GetWhere(x => x.Username == request.Username))
                   .FirstOrDefault() 
                   ?? throw new NotFoundException(ExceptionConstants.NotFound<User>());

        if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            throw new AppException("Wrong password");
        return CreateToken(user);
    }

    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512();
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512(passwordSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return computedHash.SequenceEqual(passwordHash);
    }

    private string CreateToken(User user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

        var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: cred);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);
        return jwt;
    }

}

public interface IAuthService
{
    public Task<User> Register(CreateUserRequest request);
    public Task<string> Login(LoginRequest request);
}