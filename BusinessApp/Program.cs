using System;
 
namespace bestapp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Printoperations p = new Printoperations();
            DoMath d = new DoMath(); 

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Choose an option:");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Reverse String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Print");
            Console.WriteLine("4) Print star");
            Console.WriteLine("5) Calculate area");
            Console.WriteLine("6) Is number p");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("0) Exit");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nSelect an option: ");
            Console.ResetColor();
 
            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    RemoveWhitespace();
                    return true;
                case "3":
                    p.PrintSomething();
                    return true;
                case "4":
                    p.PrintS();
                    return true;
                case "5":
                    d.Area();
                    return true;
                case "6":
                    d.IsP();
                    return true;  
                case "0":
                    return false;
                default:
                    return true;
            }
        }
        private static string CaptureInput()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter the string you want to modify: ");
            Console.ResetColor();
            return Console.ReadLine();
        }

        private static void ReverseString()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Reverse String");
            Console.ResetColor();
 
            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }
 
        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Remove Whitespace");
            Console.ResetColor();
 
            DisplayResult(CaptureInput().Replace(" ", ""));
        }
 
        private static void DisplayResult(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\r\nYour modified string is: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ResetColor();
            Console.ReadLine();
        }
        
    }
}