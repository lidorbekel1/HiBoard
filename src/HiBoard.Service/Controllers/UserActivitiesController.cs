using HiBoard.Application.Services;
using HiBoard.Domain.DTOs;
using HiBoard.Domain.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace HiBoard.Service.Controllers;

[ApiController]
[AllowAnonymous]
[Route("api/{userId}/activities")]
public class UserActivitiesController : ControllerBase
{
    private readonly UserActivitiesService _service;

    public UserActivitiesController(UserActivitiesService service)
    {
        _service = service;
    }

    [SwaggerOperation("Get User Activities List")]
    [HttpGet]
    public async Task<IActionResult> GetUserActivitiesAsync(int userId, CancellationToken cancellationToken)
    {
        var userActivities = await _service.GetActivitiesAsync(userId, cancellationToken);
        var response = new HiBoardResponse<IReadOnlyCollection<UserActivityDto>>(userActivities);

        return Ok(response);
    }
    
    [SwaggerOperation("Get User Activity")]
    [HttpGet("{activityId}")]
    public async Task<IActionResult> GetUserActivityAsync(int activityId, CancellationToken cancellationToken)
    {
        var userActivity = await _service.GetUserActivityAsync(activityId, cancellationToken);
        var response = new HiBoardResponse<UserActivityDto>(userActivity);
            
        return Ok(response);
    }
    
    [SwaggerOperation("Update User Activity")]
    [HttpPatch("{activityId}")]
    public async Task<IActionResult> UpdateActivity(int activityId, [FromBody] UserActivityDto activityDto, CancellationToken cancellationToken)
    {
        var activity = await _service.UpdateUserActivityAsync(activityId, activityDto, cancellationToken);
        var response = new HiBoardResponse<UserActivityDto>(activity);
            
        return Ok(response);
    }
    
    
    [SwaggerOperation("Create User Activity")]
    [HttpPost]
    public async Task<IActionResult> CreateActivity(int userId,[FromBody] UserActivityDto activityDto, CancellationToken cancellationToken)
    {
        var activity = await _service.CreateUserActivityAsync(userId, activityDto, cancellationToken);
        var response = new HiBoardResponse<UserActivityDto>(activity);

        return Ok(response);
    }
    
    [SwaggerOperation("Delete User Activity")]
    [HttpDelete("{activityId}")]
    public async Task<IActionResult> UpdateActivity(int activityId, CancellationToken cancellationToken)
    {
        await _service.DeleteUserActivityAsync(activityId, cancellationToken);

        return NoContent();
    }

    [SwaggerOperation("Assign Template to user")]
    [HttpPost("/assign/{templateId}")]
    public async Task<IActionResult> AssignTemplateToUser(int userId,int templateId, CancellationToken cancellationToken)
    {
        await _service.AssignTemplateToUser(userId,templateId, cancellationToken);

        return NoContent();
    }
}