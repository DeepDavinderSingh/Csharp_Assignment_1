using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class SumOfDigits
    {
        public void SumOfDigitsMethod()
        {
            try
            {
                int remainder, Number, sum = 0, Length;
                Console.WriteLine("Enter the number:");
                Number = Convert.ToInt32(Console.ReadLine());

                Length = Number.ToString().Length;

                for (int i = 0; i < Length; i++)
                {
                    remainder = Number % 10;
                    sum += remainder;
                    Number /= 10;
                }
                Console.WriteLine("The Sum of digits of a number is: {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid input");
            }

        }
    }
}
