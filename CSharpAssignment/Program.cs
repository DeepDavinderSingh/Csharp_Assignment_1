using System;
using System.Collections;

namespace CSharpAssignment

{
    class Program
    {
        public static void Main()
        {
            string? userDecision;
            int? userChoice;

            do
            {
                do
                {
                    Console.WriteLine("___________Menu Driven Project___________");
                    Console.WriteLine("Please enter your Choice:");
                    Console.WriteLine("1: To print a triangle pattern");
                    Console.WriteLine("2: To print a table of given number");
                    Console.WriteLine("3: To print a * pattern");
                    Console.WriteLine("4: To calculate the sum of digits of a number");

                    string? choice = Console.ReadLine();
                    bool Istrue = int.TryParse(choice, out int Result);
                    if (Istrue)
                    {
                        userChoice = Result;
                    }
                    else
                    {
                        userChoice = null;
                        Console.WriteLine("Invalid choice! please enter a valid choice");
                    }
                } while (userChoice == null);

                switch (userChoice)
                {
                    case 1:
                        PrintingTriangle.PrintTriangleMethod();
                        break;

                    case 2:
                        PrintingTable.PrintTableMethod();
                        break;

                    case 3:
                        PrintingPyramid Pattern = new PrintingPyramid();
                        Pattern.PatternPrintMethod();
                        break;
                    case 4:
                        SumOfDigits digit = new SumOfDigits();
                        digit.SumOfDigitsMethod();
                        break;

                    default:
                        Console.WriteLine("Please Enter valid Choice");
                        break;
                }

                do
                {
                    Console.WriteLine("For Main Menu, Press: Yes, To Exit from the Program, Press: No ");
                    userDecision = Console.ReadLine().ToUpper();
                    if (userDecision != "YES" && userDecision != "NO")
                    {
                        Console.WriteLine("Invalid Input! Press Yes or No");
                    }
                }
                while (userDecision != "YES" && userDecision != "NO");

            }
            while (userDecision.ToUpper() == "YES");


        }

    }
}




