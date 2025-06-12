namespace bestapp.Services;

public interface IStringService
{
    string ReverseString(string input);
    string RemoveWhitespace(string input);
}

public class StringService : IStringService
{
    public string ReverseString(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;
            
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return string.Concat(charArray);
    }

    public string RemoveWhitespace(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;
            
        return input.Replace(" ", "");
    }
}