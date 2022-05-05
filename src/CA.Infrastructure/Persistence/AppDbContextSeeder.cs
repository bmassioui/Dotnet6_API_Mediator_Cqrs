using CA.Application.Interfaces.Repositories;
using CA.Domain.Entities;
using CA.Domain.Enums;
using Microsoft.Extensions.Logging;

namespace CA.Infrastructure.Persistence;

/// <summary>
/// Db Seeder
/// </summary>
public static class AppDbContextSeeder
{
    /// <summary>
    /// Seed Db with default data
    /// </summary>
    /// <param name="ownerRepository"></param>
    /// <returns></returns>
    public static async Task SeedDefaultOwnerWithccounts(IOwnerRepository ownerRepository, IUnitOfWork unitOfWork, ILogger logger)
    {
        var isAlreadyHasData =  await ownerRepository.GetAsync(includeDeleted: true);

        if (isAlreadyHasData.Any())
        {
            logger.LogInformation("Db already seeded");
            return;
        }

        logger.LogInformation("Seeding default data into db ...");

        var ownersWithAccounts = GetPreconfiguredOwnerWithAccounts();
        ownerRepository.AddRange(ownersWithAccounts);

        await unitOfWork.SaveChangesAsync();
    }


    #region private methods
    /// <summary>
    /// Get Preconfigured Owner with Accounts
    /// </summary>
    /// <returns></returns>
    private static ICollection<Owner> GetPreconfiguredOwnerWithAccounts()
    {
        return new List<Owner>()
        {
            new Owner(){
                Name = "Nathan D. Peck",
                DateOfBirth = new DateTime(year: 1990, month: 3, day: 24),
                Address = "3802 Earnhardt Drive Louisville, KY 40202",
                Accounts = new List<Account>{
                    new Account{AccountType = AccountType.Admin
                    }
                    }},
            new Owner(){
                Name = "Heather I. Piscitelli",
                DateOfBirth = new DateTime(year: 1987, month: 5, day: 2),
                Address = "852 Hill Haven Drive Cleburne, TX 76031",
                Accounts = new List<Account>{
                    new Account{AccountType = AccountType.User }
                    }}
        };
    }
    #endregion private methods
}