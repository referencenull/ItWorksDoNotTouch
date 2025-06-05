namespace bestapp;

public class Printoperations{
    public void PrintSomething(){
        char ch = 'A';
           int i, j, k, m, n;
           Console.ForegroundColor = ConsoleColor.Green;
           Console.Write("Enter the number of rows:");
           Console.ResetColor();
           n = int.Parse(Console.ReadLine());
           
           Console.ForegroundColor = ConsoleColor.Yellow;
           for (i = 1; i <= n; i++)
           {
               for (j = n; j >= i; j--)
               {
                   Console.Write(" ");
               }
               for (k = 1; k <= i; k++)
               {
                   Console.Write(ch++);
               }
               ch--;
               for (m = 1; m < i; m++)
               {
                   Console.Write(--ch);
               }
               Console.Write("\n");
               ch = 'A';
           }
           Console.ResetColor();
           
           Console.ForegroundColor = ConsoleColor.DarkGray;
           Console.WriteLine("\nPress Enter to continue...");
           Console.ResetColor();
           Console.ReadLine();
    }
    
    public void PrintS()
    {
         int i, j, k, l, n;
           char c = '*';
           Console.ForegroundColor = ConsoleColor.Green;
           Console.Write("Enter the number of rows:");
           Console.ResetColor();
           n = int.Parse(Console.ReadLine());
           
           Console.ForegroundColor = ConsoleColor.Magenta;
           for (i = 1; i <= n; i++)
           {
               for (j = 1; j <= n - i; j++)
               {
                   Console.Write(" ");
               }
               for (k = 1; k <= i; k++)
               {
                   Console.Write(c);
               }
               for (l = i - 1; l >= 1; l--)
               {
                   Console.Write(c);
               }
               Console.Write("\n");
           }
           Console.ResetColor();
           
           Console.ForegroundColor = ConsoleColor.DarkGray;
           Console.WriteLine("\nPress Enter to continue...");
           Console.ResetColor();
           Console.ReadLine();

    }
    public void Check()
    {
        string str, revstr = "";
           Console.ForegroundColor = ConsoleColor.Green;
           Console.Write("Enter string: ");
           Console.ResetColor();
           str = Console.ReadLine();
           for (int i = str.Length - 1; i >= 0; i--) //String Reverse  
           {
               revstr += str[i].ToString();
           }
           if (revstr.ToLower() == str.ToLower()) // Checking whether string is palindrome or not  
           {
               Console.ForegroundColor = ConsoleColor.Green;
               Console.Write("Entered string {0} is a Palindrome string. ", str);
           }
           else
           {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.Write("Entered string {0} is not a Palindrome string. ", str);
           }
           Console.ResetColor();
           
           Console.ForegroundColor = ConsoleColor.DarkGray;
           Console.WriteLine("\nPress Enter to continue...");
           Console.ResetColor();
           Console.ReadLine();
    }

}