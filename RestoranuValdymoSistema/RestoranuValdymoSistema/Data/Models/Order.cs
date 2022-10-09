using RestoranuValdymoSistema.Data.Models.Base;

namespace RestoranuValdymoSistema.Data.Models;

public class Order : BaseEntity
{
    public string Item { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set;  }
    public decimal Price { get; set; }
    public Guid RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    public IEnumerable<Note> Notes { get; set; }
}