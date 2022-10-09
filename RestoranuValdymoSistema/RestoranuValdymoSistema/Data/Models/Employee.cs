using RestoranuValdymoSistema.Data.Models.Base;

namespace RestoranuValdymoSistema.Data.Models;

public class Employee : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Role { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Guid RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
}