using Microsoft.AspNetCore.Mvc;

namespace todoapp.Controllers
{
  [ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet("/")]
    public string Get()
    {
      return "Hello World Controller";
    }
  }
}