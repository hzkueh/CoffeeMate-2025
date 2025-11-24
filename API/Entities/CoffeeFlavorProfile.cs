using System;

namespace API.Entities;

public class CoffeeFlavorProfile
{
    public required string CoffeeId { get; set; }
    public required string FlavorProfileId { get; set; }
    public required string Intensity { get; set; }
    public Coffee Coffee { get; set; } = null!;
    public FlavorProfile FlavorProfile {get;set;} = null!;
}
