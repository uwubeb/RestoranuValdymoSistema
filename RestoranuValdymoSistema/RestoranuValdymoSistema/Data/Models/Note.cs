using RestoranuValdymoSistema.Data.Models.Base;

namespace RestoranuValdymoSistema.Data.Models;

public class Note : BaseEntity
{
    public string Text { get; set; }
    
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
}