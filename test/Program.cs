using System;

namespace test
{
    class Program
    {
        static public bool devidedByZero = false;
        static public bool wronglyFormated = false;
        static void Main()
        {
            WelcomeMessage();

            bool exit = false;
            string MultipicationSymbol = "*";
            string DevideSymbol = "/";
            string AddtionSymbol = "+";
            string SubstractionSymbol = "-";
            while (!exit)
            {
                MathLabMessage();
                Console.WriteLine("-1 to exit");
                Console.WriteLine("Enter a quary:");
                devidedByZero = false;
                wronglyFormated = false;
                string equation = Console.ReadLine();
                double result;

                if (equation == "-1")
                {
                    exit = true;
                }
                else
                {
                    if (equation.Contains(MultipicationSymbol))
                    {

                        double[] numbers = ReadEquation(equation, MultipicationSymbol);
                        result = Multipication(numbers[0], numbers[1]);
                        if (wronglyFormated)
                            result = Double.NaN;
                        PrintResult(result);
                    }
                    else if (equation.Contains(DevideSymbol))
                    {
                        double[] numbers = ReadEquation(equation, DevideSymbol);
                        result = Devide(numbers[0], numbers[1]);
                        if (wronglyFormated)
                            result = Double.NaN;
                        PrintResult(result);

                    }
                    else if (equation.Contains(AddtionSymbol))
                    {
                        double[] numbers = ReadEquation(equation, AddtionSymbol);
                        result = Addtion(numbers[0], numbers[1]);
                        if (wronglyFormated)
                            result = Double.NaN;
                        PrintResult(result);
                    }
                    else if (equation.Contains(SubstractionSymbol))
                    {
                        double[] numbers = ReadEquation(equation, SubstractionSymbol);
                        result = Substration(numbers[0], numbers[1]);
                        if (wronglyFormated)
                            result = Double.NaN;
                        PrintResult(result);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No valid symbol was entered");
                    }
                }
            }
        }
        static double[] ReadEquation(string equation, string Symbol)
        {
            string[] Snumbers = equation.Split(Symbol);
            double[] numbers = new double[2];
            numbers[0] = ConvertToDouble(Snumbers[0]);
            numbers[1] = ConvertToDouble(Snumbers[1]);
            if (Snumbers.Length > 2)
                wronglyFormated = true;
            return numbers;
        }
        static double Multipication(double number1, double number2)
        {
            return number1 * number2;
        }
        static double Devide(double number1, double number2)
        {
            if (number1 == 0 || number2 == 0)
            {
                devidedByZero = true;
                return double.NaN;
            }

            return (number1 / number2);
        }
        static double Addtion(double number1, double number2)
        {

            return number1 + number2;
        }
        static double Substration(double number1, double number2)
        {
            return number1 - number2;
        }
        static double ConvertToDouble(string Snumber)
        {
            double number;
            bool success = double.TryParse(Snumber, out number);
            if (success)
                return number;
            return Double.NaN;
        }
        static void PrintResult(double result)
        {
            Console.Clear();
            if (Double.IsNaN(result))
            {
                if (devidedByZero)
                {
                    Console.WriteLine("you dived 0 by 0");
                }
                if (wronglyFormated)
                {
                    Console.WriteLine("Ether the equation in wrongly formated");
                }
            }
            else
            {
                Console.WriteLine("The result is:");
                Console.WriteLine(result);
            }

        }
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my simple calculator");
            Console.WriteLine("Write in a quary with 2 numbers and a math symbol in the middle");
            Console.WriteLine("Exemple: 2 + 2");
        }
        static void MathLabMessage()
        {
            Console.WriteLine("* = Muliplication");
            Console.WriteLine("/ = Devide");
            Console.WriteLine("+ = Addtion");
            Console.WriteLine("- = Substraction");
        }
    }
}
