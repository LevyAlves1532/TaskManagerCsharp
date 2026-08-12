namespace TaskManager.Application.Exceptions;

public class ExceptionFormBodyValidate : Exception
{
    public ExceptionFormBodyValidate(string? message) : base(message)
    {
    }
}
