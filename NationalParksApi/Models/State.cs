using System.Collections.Generic;

namespace NationalParksApi;

public class State
{
    public int StateId { get; set; }
    public string Name { get; set; }
    public List<NatlPark> NatlParks { get; set; }
    public List<StatePark> StateParks { get; set; }
}
