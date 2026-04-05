namespace SmartPlanner360.API.Models;

public class PlanDto
{
    public Guid PlanId { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedAt { get; set; }
}
