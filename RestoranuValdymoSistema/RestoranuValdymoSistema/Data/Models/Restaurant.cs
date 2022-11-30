using RestoranuValdymoSistema.Data.Models.Base;

namespace RestoranuValdymoSistema.Data.Models;

public class Restaurant : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public IEnumerable<User> Users { get; set; }
    public IEnumerable<Order> Orders { get; set; }
}