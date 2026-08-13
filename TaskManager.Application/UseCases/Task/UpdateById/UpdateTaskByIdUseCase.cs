using TaskManager.Application.Exceptions;
using TaskManager.Communication.Enums;
using TaskManager.Communication.Requests;

namespace TaskManager.Application.UseCases.Task.UpdateById;

public class UpdateTaskByIdUseCase
{
    public void Execute(Guid id, RequestTaskJson request)
    {
        if (false)
        {
            throw new ExceptionNotFound("Tarefa não encontrada");
        }

        string name = request.Name.Trim();

        if (name.Length == 0)
        {
            throw new ExceptionFormBodyValidate("O campo nome precisa ser preenchido");
        }

        if (name.Length > 100)
        {
            throw new ExceptionFormBodyValidate("O campo nome deve ter no máximo 100 caracteres");
        }

        if (request.DueDate <= DateTime.Now)
        {
            throw new ExceptionFormBodyValidate("A data de entrega da tarefa deve ser maior que a data atual");
        }

        if (!Enum.IsDefined(typeof(PriorityTask), request.Priority))
        {
            throw new ExceptionFormBodyValidate("A prioridade da tarefa está com um valor inválido");
        }

        if (!Enum.IsDefined(typeof(StatusTask), request.Status))
        {
            throw new ExceptionFormBodyValidate("O status da tarefa está com um valor inválido");
        }
    }
}
