using System;

namespace Supporting.Library
{
    public class Calculator : AbstractCalculator, ICalculator
    {
        // CALC
        public Calculator()
        {

        }
        public int Add(int number1, int number2)
        {
            WriteMessage("Add Operation");
            return number1 + number2;
        }

        public int Minus(int number1, int number2)
        {
            WriteMessage("Minus");
            return number1 - number2;
        }

        public override void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        public override void SayHello(string input)
        {
            Console.WriteLine(input);
        }
    }

}
