using Microsoft.AspNetCore.Mvc;
using todoapp.Data;
using todoapp.Models;

namespace todoapp.Controllers
{
  [ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet("/")]
    public IActionResult Get([FromServices] AppDbContext context)
      => Ok(context.Todos.ToList());

    [HttpPost("/")]
    public IActionResult Post([FromBody] Todo todo, [FromServices] AppDbContext context)
    {
      context.Add(todo);
      context.SaveChanges();
      return Ok(todo);
    }

    [HttpGet("/{id:int}")]
    public IActionResult GetById([FromRoute] int id, [FromServices] AppDbContext context)
    {
      var model = context.Todos.FirstOrDefault(x => x.Id == id);
      if (model == null)
        return NotFound();

      return Ok(model);
    }

    [HttpPut("/{id:int}")]
    public IActionResult Put([FromRoute] int id, [FromBody] Todo todo, [FromServices] AppDbContext context)
    {
      var model = context.Todos.FirstOrDefault(x => x.Id == id);
      if (model == null)
        return NotFound();

      model.Title = todo.Title;
      model.Done = todo.Done;

      context.Update(model);
      context.SaveChanges();

      return Ok(model);
    }

    [HttpDelete("/{id:int}")]
    public IActionResult Delete([FromRoute] int id, [FromServices] AppDbContext context)
    {
      var model = context.Todos.FirstOrDefault(x => x.Id == id);
      if (model == null)
        return NotFound();
      context.Todos.Remove(model);
      context.SaveChanges();
      return Ok(model);
    }
  }
}