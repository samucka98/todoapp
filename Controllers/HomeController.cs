using Microsoft.AspNetCore.Mvc;
using todoapp.Data;

namespace todoapp.Controllers
{
  [ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet("/")]
    public string Get([FromServices] AppDbContext context)
    {
      return "Home Controller";
    }
  }
}