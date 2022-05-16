using System;

class program 
{ 
    public static void Main()
    {

        Console.WriteLine("Enter the number:");
        int _Number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the width:");
        int _Width = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= _Width; i++)
        {
            for (int j = _Width; j >= i; j--)
            {
                Console.Write(_Number);
            }
            Console.WriteLine();
        }
    }
}