using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class PrintingTable
    {
        public static void PrintTableMethod()
        {
            //string? tableOf="";
            //string? tableUpto= "";

            string? tableOf;
            string? tableUpto;
            Console.WriteLine("Please Enter the Number for which you want to Print a Table:");

            tableOf = Console.ReadLine();
            bool isTrue1 = int.TryParse(tableOf, out int Result1);

            if (isTrue1)
            {
                Console.WriteLine("Please Enter the Endpoint upto which you want to Print Table:");
                tableUpto = Console.ReadLine();
                bool isTrue2 = int.TryParse(tableUpto, out int Result2);
                if (isTrue2)
                {
                    int counter = 1;
                    while (counter <= Result2)
                    {
                        Console.WriteLine("{0} x {1} = {2}", tableOf, counter, Result1 * counter);
                        counter++;
                    }
                }
                else
                {
                    Console.WriteLine("please enter valid Endpoint");
                }
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }
        }
    }
}

