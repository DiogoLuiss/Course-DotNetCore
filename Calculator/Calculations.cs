using Calculator.count;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
    public Subtraction SubtractionCalc { get; private set; }
    public Sum SumCalc { get; private set;}

    public Multiplication MultiplicationCalc = new Multiplication();
    public Division DivisionCalc = new Division();

      public Calculations()
        {
            this.SubtractionCalc = new Subtraction();
            this.SumCalc = new Sum();
        }

    }
}
