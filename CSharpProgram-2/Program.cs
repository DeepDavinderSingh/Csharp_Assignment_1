using System;

class program
{
    public static void Main()
    {
        //Program to print star pattern
        
        Console.WriteLine("Enter the number:");
        int Number = Convert.ToInt32(Console.ReadLine());

        int i, j, k;

        for (i = 1; i <= Number; i++)
        {
            for (k = 1; k <= Number - i; k++)
            {
                Console.Write(" ");                 
            }
            for (j = 1; j <= i; j++)
            {
                Console.Write("* ");                
            }

            Console.WriteLine();
        }
    }
    
}
