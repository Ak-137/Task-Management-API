using System.ComponentModel.DataAnnotations;
using TaskManagement.Api.Models.Enums;

namespace TaskManagement.Api.Models.DTOs;

public class UpdateTaskDto
{
    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    public TaskPriority Priority { get; set; }

    [Required]
    public TaskManagement.Api.Models.Enums.TaskStatus Status { get; set; }
}
