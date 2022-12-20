using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Variavies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de variaveis");
            int idade;
            idade = 19 + 10;
            
            Console.WriteLine("A idade é " + idade);
            double Salary; //Double tipagem para numero quebrado;
            Salary =  5.20;

            Console.WriteLine("Tipagem com numero quebrado" +  Salary);
            Console.ReadKey(true); 

            int ValorInteiro;
            double ValorQubrado;
            ValorQubrado = 5.50;
            ValorInteiro = (int)ValorQubrado; ///Posso vonverter o valor dessa forma.


            long ValueHigh = 10000000000000; //Armazena numeros grandes;



            short ValueLow = 16000; //Não aceita valores tão altos;

            float height = 1.52f; //Deixa mais preciso os valores quebrados;;


        }

   
    }
}
