using Microsoft.EntityFrameworkCore;

namespace NationalParksApi.Models;

public class NationalParksApiContext : DbContext
{
  public DbSet<NatlPark> NatlParks { get; set; }
  public DbSet<StatePark> StateParks { get; set; }
  public DbSet<State> States { get; set; }

  public NationalParksApiContext(DbContextOptions options) : base(options) { }
}

