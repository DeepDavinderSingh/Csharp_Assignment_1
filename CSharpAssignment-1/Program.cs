using System;

class program 
{ 
    public static void Main()
    {
        Console.WriteLine("Enter the number:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the width:");
        int width = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= width; i++)
        {
            for (int j = width; j >= i; j--)
            {
                Console.Write(n);
            }
            Console.WriteLine();
        }
    }

}