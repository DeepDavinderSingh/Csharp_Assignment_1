using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class PrintingPyramid
    {
        public void PatternPrintMethod()
        {
            Console.WriteLine("Enter the number:");
            string Number = Console.ReadLine();
            bool isTrue = int.TryParse(Number, out int Result);

            if (isTrue)
            {
                if (Result == 0)
                {
                    Console.WriteLine("Please Enter Valid Input, It cannot be 0");
                }
                else
                {
                    int i, j, k;

                    for (i = 1; i <= Result; i++)
                    {
                        for (k = 1; k <= Result - i; k++)
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
            else
            {
                Console.WriteLine("Invalid Number! Please Enter valid number");
            }
        }

    }
}
