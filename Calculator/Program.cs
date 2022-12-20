using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
Calculations AllCalculations = new Calculations();



            //Console.WriteLine(AllCalculations.DivisionCalc.Calc(10, 5));
            Console.WriteLine(AllCalculations.MultiplicationCalc.Calc(10, 20));
            Console.WriteLine(AllCalculations.SumCalc.Calc(10, 20));
            Console.WriteLine(AllCalculations.SubtractionCalc.Calc(30,10));
            Console.WriteLine(AllCalculations.DivisionCalc.Calc(10, 5));
            Console.ReadKey(true);


        }
    }
}
