namespace bestapp.Models;

public class StringOperationRequest
{
    public string Input { get; set; } = string.Empty;
}

public class StringOperationResponse
{
    public string Result { get; set; } = string.Empty;
    public string Operation { get; set; } = string.Empty;
}

public class PatternRequest
{
    public int Rows { get; set; }
}

public class PatternResponse
{
    public string Pattern { get; set; } = string.Empty;
    public string PatternType { get; set; } = string.Empty;
}

public class CircleAreaRequest
{
    public double Radius { get; set; }
}

public class CircleAreaResponse
{
    public double Area { get; set; }
    public double Radius { get; set; }
}

public class PrimeCheckRequest
{
    public int Number { get; set; }
}

public class PrimeCheckResponse
{
    public int Number { get; set; }
    public bool IsPrime { get; set; }
}

public class PalindromeCheckRequest
{
    public string Input { get; set; } = string.Empty;
}

public class PalindromeCheckResponse
{
    public string Input { get; set; } = string.Empty;
    public bool IsPalindrome { get; set; }
}