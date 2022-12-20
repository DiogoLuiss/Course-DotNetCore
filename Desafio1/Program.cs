using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 4000.0;

            if (salario >= 1900 && salario <= 2800)
            {
                Console.WriteLine("Seu IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;");
            }
            if (salario >= 2800.01 && salario <= 3751.0)
            {
                Console.WriteLine("Seu IR é de 15% e pode deduzir R$ 350;");
            }
            if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("Seu o IR é de 22.5% e pode deduzir R$ 636.");
            }


            int mes = 1;
            double investimento = 1000;

            while (mes <=12)
            {
                investimento = investimento + investimento * 0.005;

                Console.WriteLine("No mes: " + mes + " Vc tem R$ " + (int)investimento);

                mes = mes + 1;

            }

            for (int i = 1; i < 10; i++)
            {
                for (int i2 = 0; i2 < i; i2++)
                {
                    Console.WriteLine("passei");
                }
                Console.WriteLine(i);
            }

            for (int Number = 0; Number <= 100; Number++)
            {
                if (Number % 3 == 0 )
                {
                    Console.WriteLine(Number);
                }
            }


            Console.ReadKey(true);
        }
    }
}
