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
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Reverse String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Print");
            Console.WriteLine("4) Print star");
            Console.WriteLine("5) Calculate area");
            Console.WriteLine("6) Is number p");
            Console.WriteLine("7) Random cool ASCII image");
            Console.WriteLine("0) Exit");
            Console.Write("\r\nSelect an option: ");
 
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
                case "7":
                    p.PrintRandomAsciiArt();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }
        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");
 
            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }
 
        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");
 
            DisplayResult(CaptureInput().Replace(" ", ""));
        }
 
        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
        
    }
}