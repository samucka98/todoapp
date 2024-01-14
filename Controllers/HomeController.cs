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

    [HttpPost("/")]
    public Todo Post([FromBody] Todo todo, [FromServices] AppDbContext context)
    {
      context.Add(todo);
      context.SaveChanges();
      return todo;
    }

    [HttpGet("/{id:int}")]
    public Todo GetById([FromRoute] int id, [FromServices] AppDbContext context)
    {
      return context.Todos.FirstOrDefault(x => x.Id == id);
    }
  }
}