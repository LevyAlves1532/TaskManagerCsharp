using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Exceptions;
using TaskManager.Application.UseCases.Task.Register;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestRegisterTaskJson request)
    {
        try
        {
            var useCase = new RegisterTaskUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch (ExceptionFormBodyValidate ex)
        {
            var responseErrorsJson = new ResponseErrorsJson();

            responseErrorsJson.Errors.Add(ex.Message);

            return BadRequest(responseErrorsJson);
        }
    }
}
