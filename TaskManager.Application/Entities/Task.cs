using TaskManager.Communication.Enums;

namespace TaskManager.Application.Entities;

public class Task
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public PriorityTask Priority { get; set; }
    public DateTime DueDate { get; set; }
    public StatusTask Status { get; set; }
}
