using System.ComponentModel.DataAnnotations;

namespace CA.Domain.Entities;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
}