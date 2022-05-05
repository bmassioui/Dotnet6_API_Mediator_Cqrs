using System.ComponentModel;

namespace CA.Domain.Enums;

/// <summary>
/// Account Type
/// </summary>
public enum AccountType : ushort
{
    [Description("Simple User")]
    User = 0,

    [Description("Administrator")]
    Admin = 1
}