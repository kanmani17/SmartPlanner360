
using SmartPlanner360.API.Models;

namespace SmartPlanner360.API.Services;

public class PlanService : IPlanService
{
    private readonly List<PlanDto> _plans = [];

    public Task<IEnumerable<PlanDto>> GetPlansAsync() => Task.FromResult(_plans.AsEnumerable());
  

    public Task<PlanDto> CreatePlanAsync(PlanDto planDto)
    {
        planDto.PlanId = Guid.NewGuid();
        planDto.CreatedAt = DateTime.UtcNow;
        _plans.Add(planDto);
        return Task.FromResult(planDto);
    }
}