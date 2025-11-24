using System;

namespace API.Entities;

public class CoffeeRecommendation
{
    public required string Id { get; set; }
    public required string UserId { get; set; }
    public required string CoffeeId { get; set; }
    public decimal Score { get; set; }
    public string Reason { get; set; } = "";
    public bool WasAccepted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime ViewAt { get; set; } = DateTime.UtcNow;
    public CoffeeUser User { get; set; } = null!;
    public Coffee Coffee { get; set; } = null!;
}
