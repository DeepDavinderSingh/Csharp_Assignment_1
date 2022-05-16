using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the number:");
        int Number = Convert.ToInt32(Console.ReadLine());
        int addition = Sum(Number);

        Console.Write("Sum of digits of a nummber is : {0}", + addition);
    }

    static int Sum(int Number)
    {
           int remainder, sum = 0;
           int Length = Number.ToString().Length;
                
            for (int i = 0; i <Length ; i++)
            {
            remainder = Number % 10;
            sum = sum + remainder;
            Number = Number / 10;
            }
            return sum;            
    }

}
