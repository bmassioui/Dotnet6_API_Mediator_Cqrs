using Microsoft.AspNetCore.Mvc;

namespace CA.API.Controllers;

[ApiController]
public class BaseApiController : ControllerBase
{
    private readonly ILogger<BaseApiController> _logger;

    public BaseApiController(ILogger<BaseApiController> logger)
    {
        _logger = logger ?? throw new ArgumentException(nameof(logger));
    }
}