using Microsoft.AspNetCore.Components;

namespace CA.API.Controllers;

[Route("/api/[controller]/")]
public class AccountController : BaseApiController
{
    public AccountController(ILogger<BaseApiController> logger) : base(logger)
    {
    }
}