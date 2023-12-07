namespace bestapp;

public class DoMath
{
    public void Area(){
        {
           Console.Write("Enter Radius: ");
           double rad = Convert.ToDouble(Console.ReadLine());
           double area = Math.PI * rad * rad;
           Console.WriteLine("Area of circle is: " + area);
           Console.ReadLine();
       }   
    }

    public void CheckLeap()
    {
        Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Entered year {0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("Entered year {0} is not a leap year.", year);
            }
 
            Console.ReadLine();
    }

    public void IsP()
    {
        int num;
           bool x = true;
           Console.WriteLine("Enter the Number to check Prime: ");
           num = int.Parse(Console.ReadLine());
           for (int i = 2; i <= num / 2; i++){if (num % i == 0){ Console.WriteLine("Number is not P.");x = false; break;} } if (x == true) Console.WriteLine("Number is P.");
           Console.ReadKey();
    }

}