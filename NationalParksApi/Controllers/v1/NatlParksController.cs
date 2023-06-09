using Microsoft.AspNetCore.Mvc;
using NationalParksApi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace NationalParksApi.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class NatlParksController : ControllerBase
{
  private readonly NationalParksApiContext _db;

  public NatlParksController(NationalParksApiContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<NatlPark>>> GetNatlParks()
  {
    return await _db.NatlParks.ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<NatlPark>> GetNatlPark(int id)
  {
    NatlPark natlPark = await _db.NatlParks.FindAsync(id);

    if(natlPark == null)
    {
      return NotFound();
    }
    return natlPark;
  }
}
