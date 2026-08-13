using TaskManager.Application.Exceptions;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(Guid id)
    {
        if (false)
        {
            throw new ExceptionNotFound("Tarefa não encontrada");
        }

        return new ResponseTaskJson
        {
            Id = id,
            Name = "Tarefa 01",
            DueDate = DateTime.Now.AddDays(1),
            Priority = Communication.Enums.PriorityTask.Medium,
            Status = Communication.Enums.StatusTask.InProgress,
        };
    }
}
