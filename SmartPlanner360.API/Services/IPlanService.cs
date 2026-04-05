using SmartPlanner360.API.Models;

namespace SmartPlanner360.API.Services;

public interface IPlanService
{
    Task<IEnumerable<PlanDto>> GetPlansAsync();
    Task<PlanDto> CreatePlanAsync(PlanDto planDto);
}