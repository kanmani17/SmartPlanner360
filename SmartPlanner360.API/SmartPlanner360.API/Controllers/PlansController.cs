
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using SmartPlanner360.API.Models;
using SmartPlanner360.API.Services;

//wrap it up with namespace
namespace SmartPlanner360.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlansController(IPlanService planService) : ControllerBase
{
    private readonly IPlanService planService = planService;

    [HttpGet]
    public async Task<IActionResult> GetPlans()
    {
        var plans = await planService.GetPlansAsync();
        return Ok(plans);
    }

    [HttpPost]
    public async Task<IActionResult> createPlan([FromBody] PlanDto planDto)
    {
        var createdPlan = await planService.CreatePlanAsync(planDto);
        return CreatedAtAction(nameof(GetPlans), new { id = createdPlan.PlanId }, createdPlan);
    }
}