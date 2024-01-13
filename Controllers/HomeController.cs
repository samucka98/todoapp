using Microsoft.AspNetCore.Mvc;

namespace todoapp.Controllers
{
  [ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet("/")]
    public string Get()
    {
      return "Home Controller";
    }
  }
}