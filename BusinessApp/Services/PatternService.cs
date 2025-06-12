namespace bestapp.Services;

public interface IPatternService
{
    string GenerateLetterPattern(int rows);
    string GenerateStarPattern(int rows);
    bool IsPalindrome(string input);
}

public class PatternService : IPatternService
{
    public string GenerateLetterPattern(int rows)
    {
        if (rows <= 0) return string.Empty;
        
        var result = new System.Text.StringBuilder();
        char ch = 'A';
        
        for (int i = 1; i <= rows; i++)
        {
            // Add spaces
            for (int j = rows; j >= i; j--)
            {
                result.Append(" ");
            }
            
            // Add ascending characters
            for (int k = 1; k <= i; k++)
            {
                result.Append(ch++);
            }
            
            ch--;
            
            // Add descending characters
            for (int m = 1; m < i; m++)
            {
                result.Append(--ch);
            }
            
            result.AppendLine();
            ch = 'A';
        }
        
        return result.ToString();
    }

    public string GenerateStarPattern(int rows)
    {
        if (rows <= 0) return string.Empty;
        
        var result = new System.Text.StringBuilder();
        char c = '*';
        
        for (int i = 1; i <= rows; i++)
        {
            // Add spaces
            for (int j = 1; j <= rows - i; j++)
            {
                result.Append(" ");
            }
            
            // Add stars
            for (int k = 1; k <= i; k++)
            {
                result.Append(c);
            }
            
            for (int l = i - 1; l >= 1; l--)
            {
                result.Append(c);
            }
            
            result.AppendLine();
        }
        
        return result.ToString();
    }

    public bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;
            
        string reversed = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i].ToString();
        }
        
        return reversed.ToLower() == input.ToLower();
    }
}