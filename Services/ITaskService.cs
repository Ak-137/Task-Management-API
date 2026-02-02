using TaskManagement.Api.Models;
using TaskManagement.Api.Models.Enums;

namespace TaskManagement.Api.Services;

public interface ITaskService
{
    Task<IEnumerable<TaskItem>> GetAllAsync(TaskStatus? status);
    Task<TaskItem?> GetByIdAsync(int id);
    Task<TaskItem> CreateAsync(TaskItem task);
    Task<bool> UpdateAsync(int id, TaskItem task);
    Task<bool> DeleteAsync(int id);
}
