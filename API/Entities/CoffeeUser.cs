using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Entities;

public class CoffeeUser
{
    public string Id { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public required string DisplayName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime LastLoginAt { get; set; } = DateTime.UtcNow;
    public required string Gender { get; set; }
    public required string Country { get; set; }
    public string Bio { get; set; } = "";

    public List<CoffeePreference> CoffeePreferences {get;set;} = [];
    public List<CoffeeRecommendation> CoffeeRecommendations {get;set;} = [];

    [JsonIgnore]
    [ForeignKey(nameof(Id))]
    public AppUser AppUser { get; set; } = null!;
}
