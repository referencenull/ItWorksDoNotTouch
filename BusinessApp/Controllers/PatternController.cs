using Microsoft.AspNetCore.Mvc;
using bestapp.Services;
using bestapp.Models;

namespace bestapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PatternController : ControllerBase
{
    private readonly IPatternService _patternService;

    public PatternController(IPatternService patternService)
    {
        _patternService = patternService;
    }

    [HttpPost("letter")]
    public ActionResult<PatternResponse> GenerateLetterPattern([FromBody] PatternRequest request)
    {
        var result = _patternService.GenerateLetterPattern(request.Rows);
        return Ok(new PatternResponse 
        { 
            Pattern = result, 
            PatternType = "Letter Pattern" 
        });
    }

    [HttpPost("star")]
    public ActionResult<PatternResponse> GenerateStarPattern([FromBody] PatternRequest request)
    {
        var result = _patternService.GenerateStarPattern(request.Rows);
        return Ok(new PatternResponse 
        { 
            Pattern = result, 
            PatternType = "Star Pattern" 
        });
    }

    [HttpPost("palindrome")]
    public ActionResult<PalindromeCheckResponse> CheckPalindrome([FromBody] PalindromeCheckRequest request)
    {
        var result = _patternService.IsPalindrome(request.Input);
        return Ok(new PalindromeCheckResponse 
        { 
            Input = request.Input,
            IsPalindrome = result
        });
    }
}