using Microsoft.AspNetCore.Mvc;
using Supporting.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpLearning.Controllers
{
    [Route("calculator")]
    public class CalculatorController : ControllerBase
    {
        private ICalculator calculator;
        public CalculatorController(ICalculator calculator)
        {
           // this.calculator = new Calculator();
            this.calculator = calculator;
        }

        [Route("add")]
        public int Add()
        {
            return calculator.Add(1, 2);
        }

        [Route("minus")]
        public int Substract()
        {
            return calculator.Minus(2, 1);
        }
    }
}
