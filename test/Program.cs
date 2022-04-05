using System;



namespace Calculator
{

    class Program
    {
        static void Main()
        {
            

            bool exit = false;
            string MultipicationSymbol = "*";
            string DevideSymbol = "/";
            string AddtionSymbol = "+";
            string SubstractionSymbol = "-";
            Calculations calc = new Calculations();
            Utilitis utilitis = new Utilitis();
            Output output = new Output();

            output.WelcomeMessage();
            while (!exit)
            {
                string equation;
                double result;

                calc.devidedByZero = false;
                utilitis.wronglyFormated = false;
                
                output.MathLabMessage();
                Console.WriteLine("-1 to exit");
                Console.WriteLine("Enter a quary:");
                equation = Console.ReadLine();

                if (equation == "-1")
                {
                    exit = true;
                }
                else
                {
                    if (equation.Contains(MultipicationSymbol))
                    {

                        double[] numbers = utilitis.ReadEquation(equation, MultipicationSymbol);
                        result = calc.Multipication(numbers);
                        if (utilitis.wronglyFormated)
                            result = Double.NaN;
                        output.PrintResult(result, calc.devidedByZero, utilitis.wronglyFormated);
                    }
                    else if (equation.Contains(DevideSymbol))
                    {
                        double[] numbers = utilitis.ReadEquation(equation, DevideSymbol);
                        result = calc.Devide(numbers);
                        if (utilitis.wronglyFormated)
                            result = Double.NaN;
                        output.PrintResult(result, calc.devidedByZero, utilitis.wronglyFormated);

                    }
                    else if (equation.Contains(AddtionSymbol))
                    {
                        double[] numbers = utilitis.ReadEquation(equation, AddtionSymbol);
                        result = calc.Addition(numbers);
                        if (utilitis.wronglyFormated)
                            result = Double.NaN;
                        output.PrintResult(result, calc.devidedByZero, utilitis.wronglyFormated);
                    }
                    else if (equation.Contains(SubstractionSymbol))
                    {
                        double[] numbers = utilitis.ReadEquation(equation, SubstractionSymbol);
                        result = calc.Substration(numbers);
                        if (utilitis.wronglyFormated)
                            result = Double.NaN;
                        output.PrintResult(result, calc.devidedByZero, utilitis.wronglyFormated);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No valid symbol was entered");
                    }
                }
            }
        }
    }
}
