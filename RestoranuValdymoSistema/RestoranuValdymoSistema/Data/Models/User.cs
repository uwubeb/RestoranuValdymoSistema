using RestoranuValdymoSistema.Data.Models.Base;

namespace RestoranuValdymoSistema.Data.Models;

public class User : BaseEntity
{
    public string Username { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public string Role { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<Restaurant> Restaurants { get; set; }
}