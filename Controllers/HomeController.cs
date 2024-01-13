using Microsoft.AspNetCore.Mvc;
using todoapp.Data;
using todoapp.Models;

namespace todoapp.Controllers
{
  [ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet("/")]
    public List<Todo> Get([FromServices] AppDbContext context)
    {
      return context.Todos.ToList();
    }
  }
}