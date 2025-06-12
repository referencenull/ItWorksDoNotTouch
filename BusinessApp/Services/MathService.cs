namespace bestapp.Services;

public interface IMathService
{
    double CalculateCircleArea(double radius);
    bool IsLeapYear(int year);
    bool IsPrime(int number);
}

public class MathService : IMathService
{
    public double CalculateCircleArea(double radius)
    {
        if (radius < 0) return 0;
        return Math.PI * radius * radius;
    }

    public bool IsLeapYear(int year)
    {
        return year % 4 == 0;
    }

    public bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number <= 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;
        
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}