using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetAll;

public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson
        {
            Tasks = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Id = Guid.NewGuid(),
                    Name = "Tarefa 01",
                    DueDate = DateTime.Now.AddMonths(1),
                    Status = Communication.Enums.StatusTask.InProgress,
                },
                new ResponseShortTaskJson
                {
                    Id = Guid.NewGuid(),
                    Name = "Tarefa 02",
                    DueDate = DateTime.Now.AddMonths(-1),
                    Status = Communication.Enums.StatusTask.Completed,
                },
            },
        };
    }
}
