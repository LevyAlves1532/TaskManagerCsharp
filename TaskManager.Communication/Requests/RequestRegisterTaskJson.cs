using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;

public class RequestRegisterTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public PriorityTask Priority { get; set; }
    public DateTime DueDate { get; set; }
    public StatusTask Status { get; set; }
}
