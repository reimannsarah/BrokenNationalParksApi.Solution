namespace NationalParksApi;

public class StatePark
{
  public int StateParkId { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public State State { get; set; }
  public int StateId { get; set; }
}
