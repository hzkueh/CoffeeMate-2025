using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Entities;

public class Coffee
{
    public required string Id { get; set; }
    public required string CoffeeName { get; set; }
    public required string CoffeeDesc { get; set; }
    public required string RoastLevel { get; set; }
    public required string Origin { get; set; }
    public required string CaffeineLevel { get; set; }
    public required bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<CoffeeFlavorProfile> CoffeeFlavorProfiles {get;set;} = [];
    public List<CoffeePreference> CoffeePreferences {get;set;} = [];
    public List<CoffeeRecommendation> CoffeeRecommendations {get;set;} = [];

    
}
