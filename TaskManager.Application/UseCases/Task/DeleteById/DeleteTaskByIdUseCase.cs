using TaskManager.Application.Exceptions;

namespace TaskManager.Application.UseCases.Task.DeleteById;

public class DeleteTaskByIdUseCase
{
    public void Execute(Guid id)
    {
        if (false)
        {
            throw new ExceptionNotFound("Tarefa não encontrada");
        }
    }
}
