using TaskManager.Communication.Responses;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskManager.Application.Utils;

public abstract class PrintError
{
    public static ResponseErrorsJson Execute(string error)
    {
        var responseErrorsJson = new ResponseErrorsJson();

        responseErrorsJson.Errors.Add(error);

        return responseErrorsJson;
    }

    public static ResponseErrorsJson Execute(List<string> errors)
    {
        var responseErrorsJson = new ResponseErrorsJson();

        foreach (var error in errors)
        {
            responseErrorsJson.Errors.Add(error);
        }

        return responseErrorsJson;
    }
}
