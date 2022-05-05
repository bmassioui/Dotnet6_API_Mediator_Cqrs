using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CA.Domain.Enums;

namespace CA.Domain.Entities;

[Table("Account")]
public class Account : BaseEntity
{
    [Required(ErrorMessage = "Account type is required")]
    public AccountType AccountType { get; set; }

    [ForeignKey(nameof(Owner))]
    public Guid OwnerId { get; set; }
    public Owner? Owner { get; set; }
}