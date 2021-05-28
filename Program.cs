using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter your forename:");
            string forename = Console.ReadLine();
            Console.WriteLine("Please enter your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"It is nice to meet you, {forename} {surname}!");

            Console.WriteLine();
            Console.WriteLine("May we have your date of birth, please? Supply it as YYYY/MM/DD.");


            Console.WriteLine("Year:");
            int yearBorn = int.Parse(Console.ReadLine());
            Console.WriteLine("Month:");
            int monthBorn = int.Parse(Console.ReadLine());
            Console.WriteLine("Day:");
            int dayBorn = int.Parse(Console.ReadLine());

            Console.WriteLine();
            DateTime dateOfBirth = new DateTime(yearBorn, monthBorn, dayBorn);
            DateTime today = DateTime.Today;
            int age = Convert.ToInt32(today.Year) - Convert.ToInt32(dateOfBirth.Year);


            Console.WriteLine($"Excellent, it follows that you are currently {age} years old.");
            Console.WriteLine();

            bool calculatorOn = true;
            while (calculatorOn)
            {
                Console.WriteLine();
                Console.Write("Now, let us do some calculations. Please enter a number operand, followed by a mathematical operation [+,-,*,/,%,^] and the second number operand. Separate your input with spaces, please.");
                Console.WriteLine("If you wish to exit the program, please type '0 0 0'.");
                string[] userInput = (Console.ReadLine()).Split(' ');
                double result;
                var operand1 = Double.Parse(userInput[0]);
                var operand2 = Double.Parse(userInput[2]);
                var sign = userInput[1];
                string operation;

                switch (sign)
                {
                    case "+":
                        operation = "adding";
                        result = operand1 + operand2;
                        Console.WriteLine($"You wished to know what would we get by {operation} {operand1} and {operand2}. The answer is {Math.Round(result, 3)}.");
                        break;
                    case "-":
                        operation = "subtracting";
                        result = operand1 - operand2;
                        Console.WriteLine($"You wished to know what would we get by {operation} {operand1} and {operand2}. The answer is {Math.Round(result, 3)}.");
                        break;
                    case "*":
                        operation = "multiplying";
                        result = operand1 * operand2;
                        Console.WriteLine($"You wished to know what would we get by {operation} {operand1} and {operand2}. The answer is {Math.Round(result, 3)}.");
                        break;
                    case "/":
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Division by 0 is forbidden. Please try another operation.");
                            break;
                        }
                        else
                        {
                            operation = "dividing";
                            result = operand1 / operand2;
                            Console.WriteLine($"You wished to know what would we get by {operation} {operand1} and {operand2}. The answer is {Math.Round(result, 3)}.");
                            break;
                        }
                    case "%":
                        if (operand2 == 0)
                        {
                            Console.WriteLine("Division by 0 is forbidden. Please try another operation.");
                            break;
                        }
                        else
                        {
                            operation = "perfoming modulo operation with";
                            result = operand1 % operand2;
                            Console.WriteLine($"You wished to know what would we get by {operation} {operand1} and {operand2}. The answer is {Math.Round(result, 3)}.");
                            break;
                        }
                    case "^":
                        operation = "performing exponentation operation with";
                        result = Convert.ToInt32(operand1) ^ Convert.ToInt32(operand2);
                        Console.WriteLine($"You wished to know what would we get by {operation} {operand1} and {operand2}. The answer is {Math.Round(result, 3)}.");
                        break;
                    case "0":
                        Console.WriteLine($"Thank you, {forename} {surname}. Goodbye.");
                        calculatorOn = false;
                        break;
                    default:
                        Console.WriteLine("The operation requested is not supported. Please try something else. ");
                        break;
                }


            }


        }

    }
}
