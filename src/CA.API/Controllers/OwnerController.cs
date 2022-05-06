using Microsoft.AspNetCore.Components;

namespace CA.API.Controllers;

[Route("/api/[controller]")]
public class OwnerController : BaseApiController
{
    public OwnerController(ILogger<BaseApiController> logger) : base(logger)
    {
    }
}