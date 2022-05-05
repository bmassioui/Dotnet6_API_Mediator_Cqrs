using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CA.Domain.Entities;

[Table("Account")]
public class Account : BaseEntity
{
    [Required(ErrorMessage = "Date created is required")]
    public DateTime DateCreated { get; set; }

    [Required(ErrorMessage = "Account type is required")]
    public string? AccountType { get; set; }

    [ForeignKey(nameof(Owner))]
    public Guid OwnerId { get; set; }
    public Owner? Owner { get; set; }
}