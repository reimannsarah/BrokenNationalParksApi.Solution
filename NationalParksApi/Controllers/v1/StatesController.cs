using Microsoft.EntityFrameworkCore;
using NationalParksApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace NationalParksApi.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class StatesController : Controller
{
  private readonly NationalParksApiContext _db;

  public StatesController(NationalParksApiContext db)
  {
    _db = db;
  }
  
  [HttpGet]
  public async Task<ActionResult<IEnumerable<State>>> GetStates()
  {
    return await _db.States.ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<State>> GetState(int id)
  {
    State state = await _db.States.FindAsync(id);
    
    if(state == null)
    {
      return NotFound();
    }
    return state;
  }
}