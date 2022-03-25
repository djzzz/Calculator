using System;

namespace test
{
    class Program
    {
        static public bool devidedByZero = false;
        static public bool wronglyFormated = false;
        static void Main(string[] args)
        {
            welcomeMessage();
            
            bool exit = false;
            string MultipicationSymbol = "*";
            string DevideSymbol = "/";
            string AddtionSymbol = "+";
            string SubstractionSymbol = "-";
            while (!exit)
            {
                
                mathLabMessage();
                Console.WriteLine("-1 to exit");
                Console.WriteLine("Enter a quary:");
                devidedByZero = false;
                string equation = Console.ReadLine();
                double result;

                if(equation == "-1")
                {
                    exit = true;
                }
                else
                {
                    if (equation.Contains(MultipicationSymbol))
                    {

                        double[] numbers = readEquation(equation, MultipicationSymbol);
                        result = Multipication(numbers[0], numbers[1]);
                        if (wronglyFormated)
                            result = Double.NaN;
                        printResult(result);
                    }
                    else if (equation.Contains(DevideSymbol))
                    {
                        double[] numbers = readEquation(equation, DevideSymbol);
                        result = Devide(numbers[0], numbers[1]);
                        if (wronglyFormated)
                            result = Double.NaN;
                        printResult(result);

                    }
                    else if (equation.Contains(AddtionSymbol))
                    {
                        double[] numbers = readEquation(equation, AddtionSymbol);
                        result = Addtion(numbers[0], numbers[1]);
                        if (wronglyFormated)
                            result = Double.NaN;
                        printResult(result);
                    }
                    else if (equation.Contains(SubstractionSymbol))
                    {
                        double[] numbers = readEquation(equation, SubstractionSymbol);
                        result = Substration(numbers[0], numbers[1]);
                        if (wronglyFormated)
                            result = Double.NaN;
                        printResult(result);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No valid symbol was entered");
                    }
                }
            }
        }
        static double[] readEquation(string equation, string SubstractionSymbol)
        {
            string[] Snumbers = equation.Split(SubstractionSymbol);
            double[] numbers = new double[2];
            numbers[0] = convertToDouble(Snumbers[0]);
            numbers[1] = convertToDouble(Snumbers[1]);
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
        static double convertToDouble(string Snumber)
        {
            double number;
            bool success = double.TryParse(Snumber, out number);
            if (success)
                return number;
            return Double.NaN;
        }
        static void printResult(double result)
        {
            if (Double.IsNaN(result))
            {
                if (devidedByZero)
                {
                    Console.Clear();
                    Console.WriteLine("you dived 0 by 0");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ether the equation in wrongly formated");
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("The result is:");
                Console.WriteLine(result);
            }
            
        }
        static void welcomeMessage()
        {
            Console.WriteLine("Welcome to my simple calculator");
            Console.WriteLine("Write in a quary with 2 numbers and a math symbol in the middle");
            Console.WriteLine("Exemple: 2 + 2");
        }
        static void mathLabMessage()
        {
            Console.WriteLine("* = Muliplication");
            Console.WriteLine("/ = Devide");
            Console.WriteLine("+ = Addtion");
            Console.WriteLine("- = Substraction");
        }
    }
}
