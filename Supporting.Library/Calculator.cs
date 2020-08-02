using System;

namespace Supporting.Library
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {

        }
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Minus(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
