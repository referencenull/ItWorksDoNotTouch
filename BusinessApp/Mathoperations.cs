namespace bestapp;

public class DoMath
{
    public void Area(){
        {
           Console.ForegroundColor = ConsoleColor.Green;
           Console.Write("Enter Radius: ");
           Console.ResetColor();
           double rad = Convert.ToDouble(Console.ReadLine());
           double area = Math.PI * rad * rad;
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("Area of circle is: " + area);
           Console.ResetColor();
           
           Console.ForegroundColor = ConsoleColor.DarkGray;
           Console.WriteLine("Press Enter to continue...");
           Console.ResetColor();
           Console.ReadLine();
       }   
    }

    public void CheckLeap()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter a year: ");
        Console.ResetColor();
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Entered year {0} is a leap year.", year);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entered year {0} is not a leap year.", year);
            }
            Console.ResetColor();
 
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Press Enter to continue...");
            Console.ResetColor();
            Console.ReadLine();
    }

    public void IsP()
    {
        int num;
           bool x = true;
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("Enter the Number to check Prime: ");
           Console.ResetColor();
           num = int.Parse(Console.ReadLine());
           for (int i = 2; i <= num / 2; i++)
           {
               if (num % i == 0)
               {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Number is not P.");
                   Console.ResetColor();
                   x = false; 
                   break;
               } 
           } 
           if (x == true) 
           {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("Number is P.");
               Console.ResetColor();
           }
           
           Console.ForegroundColor = ConsoleColor.DarkGray;
           Console.WriteLine("Press any key to continue...");
           Console.ResetColor();
           Console.ReadKey();
    }

}