using Microsoft.AspNetCore.Mvc;
using bestapp.Services;
using bestapp.Models;

namespace bestapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StringController : ControllerBase
{
    private readonly IStringService _stringService;

    public StringController(IStringService stringService)
    {
        _stringService = stringService;
    }

    [HttpPost("reverse")]
    public ActionResult<StringOperationResponse> ReverseString([FromBody] StringOperationRequest request)
    {
        var result = _stringService.ReverseString(request.Input);
        return Ok(new StringOperationResponse 
        { 
            Result = result, 
            Operation = "Reverse String" 
        });
    }

    [HttpPost("remove-whitespace")]
    public ActionResult<StringOperationResponse> RemoveWhitespace([FromBody] StringOperationRequest request)
    {
        var result = _stringService.RemoveWhitespace(request.Input);
        return Ok(new StringOperationResponse 
        { 
            Result = result, 
            Operation = "Remove Whitespace" 
        });
    }
}