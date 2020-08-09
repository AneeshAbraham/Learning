using System;
using System.Collections.Generic;
using System.Text;

namespace Supporting.Library
{
    public abstract class AbstractCalculator
    {
        public abstract void SayHello(string input);

        public virtual void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
