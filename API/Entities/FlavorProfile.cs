using System;

namespace API.Entities;

public class FlavorProfile
{
    public required string Id { get; set; }
    public required string FlavorName { get; set; }
    public required string FlavorCategory { get; set; }
    public string FlavorDesc { get; set; } = "";

    public List<CoffeeFlavorProfile> CoffeeFlavorProfiles {get;set;} = [];
}
