using Microsoft.AspNetCore.Mvc;
using bestapp.Services;
using bestapp.Models;

namespace bestapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MathController : ControllerBase
{
    private readonly IMathService _mathService;

    public MathController(IMathService mathService)
    {
        _mathService = mathService;
    }

    [HttpPost("circle-area")]
    public ActionResult<CircleAreaResponse> CalculateCircleArea([FromBody] CircleAreaRequest request)
    {
        var result = _mathService.CalculateCircleArea(request.Radius);
        return Ok(new CircleAreaResponse 
        { 
            Area = result,
            Radius = request.Radius
        });
    }

    [HttpPost("prime-check")]
    public ActionResult<PrimeCheckResponse> CheckPrime([FromBody] PrimeCheckRequest request)
    {
        var result = _mathService.IsPrime(request.Number);
        return Ok(new PrimeCheckResponse 
        { 
            Number = request.Number,
            IsPrime = result
        });
    }
}