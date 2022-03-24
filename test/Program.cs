using System;

namespace test
{
    class Program
    {
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
                        result = Multipication(equation.Split(MultipicationSymbol));
                        printResult(result);
                    }
                    else if (equation.Contains(DevideSymbol))
                    {
                        result = Devide(equation.Split(DevideSymbol));
                        printResult(result);

                    }
                    else if (equation.Contains(AddtionSymbol))
                    {
                        result = Addtion(equation.Split(AddtionSymbol));
                        printResult(result);
                    }
                    else if (equation.Contains(SubstractionSymbol))
                    {
                        result = Substration(equation.Split(SubstractionSymbol));
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
        static double Multipication(string[] Snumbers)
        {
            double number1 = convertToInt(Snumbers[0]);
            double number2 = convertToInt(Snumbers[1]);
            if (Snumbers.Length > 2)
                return Double.NaN;
            return number1 * number2;
        }
        static double Devide(string[] Snumbers)
        {
            double number1 = convertToInt(Snumbers[0]);
            double number2 = convertToInt(Snumbers[1]);
            if (Snumbers.Length > 2)
                return Double.NaN;
            return (number1 / number2);
        }
        static double Addtion(string[] Snumbers)
        {
            double number1 = convertToInt(Snumbers[0]);
            double number2 = convertToInt(Snumbers[1]);
            if (Snumbers.Length > 2)
                return Double.NaN;
            return number1 + number2;
        }
        static double Substration(string[] Snumbers)
        {
            double number1 = convertToInt(Snumbers[0]);
            double number2 = convertToInt(Snumbers[1]);
            if (Snumbers.Length > 2)
                return Double.NaN;
            return number1 - number2;
        }
        static double convertToInt(string Snumber)
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
                Console.Clear();
                Console.WriteLine("Ether the equation in wrongly formated or you dived 0 by 0");
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
