using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("TestCalculator")]
namespace Calculator
{
    class Utilitis
    {
        public bool wronglyFormated;
        public Utilitis()
        {
            this.wronglyFormated = false;
        }
        public double[] ReadEquation(string equation, string Symbol)
        {
            this.wronglyFormated = false;
            string[] Snumbers = equation.Split(Symbol);
            double[] numbers = new double[Snumbers.Length];
            for(int i = 0; i < Snumbers.Length; i++)
            {
                numbers[i] = ConvertToDouble(Snumbers[i]);
                if (Double.IsNaN(numbers[i]))
                {
                    this.wronglyFormated = true;
                }
            }
            return numbers;
        }
        public double ConvertToDouble(string Snumber)
        {
            double number;
            bool success = double.TryParse(Snumber, out number);
            if (success)
                return number;
            return Double.NaN;
        }
    }
}
