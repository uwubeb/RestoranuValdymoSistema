using RestoranuValdymoSistema.Data.Models.Base;

namespace RestoranuValdymoSistema.Data.Models;

public class Restaurant : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public List<User> Users { get; set; }
    public List<Order> Orders { get; set; }
}