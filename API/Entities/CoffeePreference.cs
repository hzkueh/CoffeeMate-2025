using System;

namespace API.Entities;

public class CoffeePreference
{
    public required string Id { get; set; }
    public required string UserId { get; set; }
    public required string CoffeeId { get; set; }
    public int Rating { get; set; }
    public string Notes { get; set; } = "";
    public bool IsLiked { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public CoffeeUser User { get; set; } = null!;
    public Coffee Coffee { get; set; } = null!;
}
