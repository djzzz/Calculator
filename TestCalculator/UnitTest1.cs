using System;
using Xunit;
using Calculator;
namespace TestCalculator
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestMultiplicationPositive()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 1, 2, 3, 4, 5 };

            //act
            double result = calc.Multipication(numbers);

            //assert
            Assert.Equal(120, result);

        }
        [Fact]
        public void TestMultiplicationNegative()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 1, 2, 3, 4, -1 };

            //act
            double result = calc.Multipication(numbers);

            //assert
            Assert.Equal(-24, result);

        }
        [Fact]
        public void TestMultiplicationZero()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 1, 2, 3, 4, 0 };

            //act
            double result = calc.Multipication(numbers);

            //assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void TestDivisionPositive()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 2, 2, 2};

            //act
            double result = calc.Devide(numbers);

            //assert
            Assert.Equal(0.5, result);
        }
        [Fact]
        public void TestDivisionNegative()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 2, 2, -1};

            //act
            double result = calc.Devide(numbers);

            //assert
            Assert.Equal(-1, result);
        }
        [Fact]
        public void TestDivisionZero()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 2, 0, 2 };

            //act
            double result = calc.Devide(numbers);

            //assert
            Assert.Equal(double.NaN, result);
        }
        [Fact]
        public void TestAdditionPositive()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 2, 2, 2 };

            //act
            double result = calc.Addition(numbers);

            //assert
            Assert.Equal(6, result);
        }
        [Fact]
        public void TestAdditionNegative()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 2, 2, -2 };

            //act
            double result = calc.Addition(numbers);

            //assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestAdditionZero()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 2, 2, 0 };

            //act
            double result = calc.Addition(numbers);

            //assert
            Assert.Equal(4, result);
        }
        [Fact]
        public void TestSubstractionPositive()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 2, 2, 2 };

            //act
            double result = calc.Substration(numbers);

            //assert
            Assert.Equal(-2, result);
        }
        [Fact]
        public void TestSubstractionNegative()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 2, 2, -2 };

            //act
            double result = calc.Substration(numbers);

            //assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void TestSubstractionZero()
        {
            //arrage
            Calculations calc = new Calculations();
            double[] numbers = { 2, 2, 0 };

            //act
            double result = calc.Substration(numbers);

            //assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void TestTranslatorMutipleSymbols()
        {
            //arrage
            Utilitis utilitis = new Utilitis();
            string symbol = "*";
            string equation = "1 * 1 / 2";

            //act
            double[] result = utilitis.ReadEquation(equation, symbol);

            //assert
            Assert.True(utilitis.wronglyFormated);
        }
        [Fact]
        public void TestTranslatorCorrect()
        {
            //arrage
            Utilitis utilitis = new Utilitis();
            string symbol = "*";
            string equation = "1 * 1 * 1";

            //act
            double[] result = utilitis.ReadEquation(equation, symbol);

            //assert
            Assert.True(!utilitis.wronglyFormated);
        }
        [Fact]
        public void TestMultipleTimes()
        {
            //arrage
            Utilitis utilitis = new Utilitis();
            string symbol = "*";
            string equation = "1 * 1 / 2";

            //act
            double[] result = utilitis.ReadEquation(equation, symbol);

            //assert
            Assert.True(utilitis.wronglyFormated);

            //arrage
            equation = "1 * 1 * 1";

            //act
            result = utilitis.ReadEquation(equation, symbol);

            //assert
            Assert.True(!utilitis.wronglyFormated);
        }
        [Fact]
        public void TestReadEquationResult()
        {
            //arrage
            Utilitis utilitis = new Utilitis();
            string symbol = "*";
            string equation = "1 * 1 * 1";
            double[] testExpect = { 1, 1, 1 };
            //act
            double[] result = utilitis.ReadEquation(equation, symbol);

            //assert
            Assert.Equal(testExpect, result);
        }
    }
}
