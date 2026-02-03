using System.ComponentModel.DataAnnotations;
using TaskManagement.Api.Models.Enums;

namespace TaskManagement.Api.Models.DTOs;

public class CreateTaskDto
{
    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    public TaskPriority Priority { get; set; }

    public TaskStatus Status { get; set; } = TaskStatus.Pending;
}
