using Microsoft.AspNetCore.Mvc;
using TaskManagement.Api.Models;
using TaskManagement.Api.Models.Enums;
using TaskManagement.Api.Services;

namespace TaskManagement.Api.Controllers;

[ApiController]
[Route("api/tasks")]
public class TasksController : ControllerBase
{
    private readonly ITaskService _service;

    public TasksController(ITaskService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] TaskStatus? status)
    {
        var tasks = await _service.GetAllAsync(status);
        return Ok(tasks);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var task = await _service.GetByIdAsync(id);
        if (task == null)
            return NotFound();

        return Ok(task);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TaskItem task)
    {
        var createdTask = await _service.CreateAsync(task);
        return CreatedAtAction(nameof(GetById), new { id = createdTask.Id }, createdTask);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, TaskItem task)
    {
        var updated = await _service.UpdateAsync(id, task);
        if (!updated)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _service.DeleteAsync(id);
        if (!deleted)
            return NotFound();

        return NoContent();
    }
}
