namespace bestapp;

public class Printoperations{
    public void PrintSomething(){
        char ch = 'A';
           int i, j, k, m, n;
           Console.Write("Enter the number of rows:");
           n = int.Parse(Console.ReadLine());
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
           Console.ReadLine();
    }
    
    public void PrintS()
    {
         int i, j, k, l, n;
           char c = '*';
           Console.Write("Enter the number of rows:");
           n = int.Parse(Console.ReadLine());
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
           Console.ReadLine();

    }
    public void Check()
    {
        string str, revstr = "";
           Console.Write("Enter string: ");
           str = Console.ReadLine();
           for (int i = str.Length - 1; i >= 0; i--) //String Reverse  
           {
               revstr += str[i].ToString();
           }
           if (revstr.ToLower() == str.ToLower()) // Checking whether string is palindrome or not  
           {
               Console.Write("Entered string {0} is a Palindrome string. ", str);
           }
           else
           {
               Console.Write("Entered string {0} is not a Palindrome string. ", str);
           }
           Console.ReadLine();
    }

    public void PrintRandomAsciiArt()
    {
        Console.Clear();
        Console.WriteLine("Random Cool ASCII Image");
        Console.WriteLine();
        
        string[] asciiImages = {
            @"       /\   /\   
      (  . .)
       )   (   
      (  v  ) 
    ^^  ^^^  ^^",
            
            @"     /\_/\  
    ( o.o ) 
     > ^ <",
            
            @"   .-''''''-.
  /         \
 |  O     O  |
 |     >     |
  \    ___  /
   '-.......-'",
            
            @"    ___
   (o o)
  (  V  )
 --m-m--",
            
            @"      /\_/\
     ( o.o )
      > ^ <
     _) (_",
            
            @"    (\   /)
   ( ._. )
  o_('v')_o"
        };
        
        Random random = new Random();
        int randomIndex = random.Next(asciiImages.Length);
        
        Console.WriteLine(asciiImages[randomIndex]);
        Console.WriteLine();
        Console.Write("Press Enter to return to Main Menu");
        Console.ReadLine();
    }

}