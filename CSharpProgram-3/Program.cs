using System;

class Program
{
    public static void Main()
    {
        //To print table of any number:

        int tableOf;
        Console.WriteLine("Print Table of:");
        tableOf = Convert.ToInt32(Console.ReadLine());

        int tableUpto;
        Console.WriteLine("Print Table Upto:");
        tableUpto = Convert.ToInt32(Console.ReadLine());

        int i = 1;

        while (i <= tableUpto)
        {
          //  Console.WriteLine(tableOf + "x" + i + "=" + tableOf * i);
            Console.WriteLine("{0} x {1} = {2}", tableOf, i, tableOf * i  );
            i++;
        }
    }
}