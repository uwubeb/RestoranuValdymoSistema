namespace RestoranuValdymoSistema.Data.Contracts.User;

public class UserContract
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public IEnumerable<Guid> RestaurantIds { get; set; }
}