using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("TestCalculator")]
namespace Calculator
{
    class Calculations
    {
        public bool devidedByZero = false;

        public Calculations()
        {
            this.devidedByZero = false;
        }
        public double Multipication(double[] numbers)
        {
            this.devidedByZero = false;
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    result = numbers[i];
                }
                else
                {
                    result *= numbers[i];
                }
            }
            return result;
        }
        public double Devide(double[] numbers)
        {
            this.devidedByZero = false;
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    this.devidedByZero = true;
                    return double.NaN;
                }
                if (i == 0)
                {
                    result = numbers[i];
                }
                else
                {
                    result = result / numbers[i];

                }
            }

            return result;
        }
        public double Addition(double[] numbers)
        {
            this.devidedByZero = false;
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    result = numbers[i];
                }
                else
                {
                    result += numbers[i];
                }
            }
            return result;
        }
        public double Substration(double[] numbers)
        {
            this.devidedByZero = false;
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    result = numbers[i];
                }
                else
                {
                    result -= numbers[i];
                }
            }
            return result;
        }
    }
}
