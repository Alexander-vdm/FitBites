using Microsoft.AspNetCore.Mvc;

namespace FitBites.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class IngredientController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        return Ok();
    }
}
