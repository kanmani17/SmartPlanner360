namespace SmartPlanner360.API.Models;

public class BucketDto
{
    public Guid BucketId { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid PlanId { get; set; }
}
