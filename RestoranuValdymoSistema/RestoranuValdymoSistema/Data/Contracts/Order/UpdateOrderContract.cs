namespace RestoranuValdymoSistema.Data.Contracts.Order;

public class UpdateOrderContract
{
    public Guid Id { get; set; }
    public string Item { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}