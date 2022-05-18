using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class PrintingTriangle
    {
        public static void PrintTriangleMethod()
        {
            try
            {
                Console.WriteLine("please enter the number:");
                int number = Convert.ToInt32(Console.ReadLine());

                //if (number.ToString().Length > 1)
                //{
                //    Console.WriteLine("Please Enter a single digit");
                //}
                //else
                //{
                Console.WriteLine("please enter the width of triangle:");
                int width = Convert.ToInt32(Console.ReadLine());
                int height = width;
                if (width != 0)
                {
                    for (int row = 1; row <= height; row++)
                    {
                        for (int col = width; col >= row; col--)
                        {
                            Console.Write(number);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid width, It cannot be 0");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
