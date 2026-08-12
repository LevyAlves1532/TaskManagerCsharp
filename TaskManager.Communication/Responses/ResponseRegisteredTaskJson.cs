using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;

public class ResponseRegisteredTaskJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public StatusTask Status { get; set; }
}
