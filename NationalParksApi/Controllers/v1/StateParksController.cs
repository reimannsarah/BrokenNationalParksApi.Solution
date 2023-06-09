using Microsoft.EntityFrameworkCore;
using NationalParksApi.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace NationalParksApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StateParksController : Controller
{
  private readonly NationalParksApiContext _db;

  public StateParksController(NationalParksApiContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<StatePark>>> GetStateParks()
  {
    return await _db.StateParks.ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<StatePark>> GetStatePark(int id)
  {
    StatePark statePark = await _db.StateParks.FindAsync(id);
    
    if(statePark == null)
    {
      return NotFound();
    }
    return statePark;
  }

}