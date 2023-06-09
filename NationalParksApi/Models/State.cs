using System.Collections.Generic;

namespace NationalParksApi;

public class NatlPark
{
    public int StateId
    public string Name { get; set; }
    public List<NatlPark> NatlParks { get; set; }
    public List<StatePark> StateParks { get; set; }
}
