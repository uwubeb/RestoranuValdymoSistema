using System.ComponentModel.DataAnnotations;

namespace RestoranuValdymoSistema.Data.Models.Base;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime CreationDate { get; set; }

    protected BaseEntity()
    {
        CreationDate = DateTime.UtcNow;
    }

}