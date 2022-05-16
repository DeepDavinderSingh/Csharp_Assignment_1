using System;

class program
{
    public static void Main()
    {
        //Console.WriteLine("Enter the number:");
        //int n = Convert.ToInt32(Console.ReadLine());

        //int i, j, k;

        //for (i = 1; i <= n; i++)
        //{
        //        for (k = 1; k <= n - i; k++)
        //        {
        //            Console.Write(" ");
        //        }
        //        for (j = 1; j <= i; j++)
        //        {
        //            Console.Write("* ");
        //        }

        //    Console.WriteLine();
        //}


        int _tableOf;
        Console.WriteLine("Table of:");
        _tableOf = Convert.ToInt32(Console.ReadLine());

        int _tableUpto;
        Console.WriteLine("Table Upto:");
        _tableUpto = Convert.ToInt32(Console.ReadLine());

        int i = 1;

        while (i <= _tableUpto)
        {
            Console.WriteLine(_tableOf + "x" + i + "=" + _tableOf * i);
            i++;
        }

        

        //for (int i = 1; i <=_tableUpto; i++)
        //{
        //    Console.WriteLine(_tableOf + "x"+ i + "=" + _tableOf * i);
        //}


        //Console.WriteLine("Enter the number:");
        //int n = Convert.ToInt32(Console.ReadLine());

        //void int Sum()
        //{
        //    for (int i = 0; i < n; i++) ;
        //    {
        //        int sum = n % 10;
        //    }
        //}

    }
    
}
