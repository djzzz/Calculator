using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Output
    {
        public Output()
        {

        }
        public void PrintResult(double result, bool devidedByZero, bool wronglyFormated)
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
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my simple calculator");
            Console.WriteLine("Write in a quary with 2 numbers and a math symbol in the middle");
            Console.WriteLine("Exemple: 2 + 2");
        }
        public void MathLabMessage()
        {
            Console.WriteLine("* = Muliplication");
            Console.WriteLine("/ = Devide");
            Console.WriteLine("+ = Addtion");
            Console.WriteLine("- = Substraction");
        }
    }
}
