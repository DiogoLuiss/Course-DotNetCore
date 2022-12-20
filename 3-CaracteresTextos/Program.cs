using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CaracteresTextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a';

            Console.WriteLine(letra);

            letra = (char)84;

            Console.WriteLine(letra);

            string List = @"Cursos:
- Curso1
- Curso2
";
            Console.WriteLine(List);

            int MyAge = 18;
            int Peoples = 1;
            

            if (MyAge >= 18 )
            {
                Console.WriteLine("Vc é maior de idade e " + (Peoples > 0 ? "Vc Está acompanhado" : "Vc está sozinho")) ;
            }
            else
            {
                Console.WriteLine("Vc é menor de idade" + (Peoples > 0 ? "Vc Está acompanhado" : "Vc está sozinho"));
            }



            Console.ReadKey(true);
        }
    }
}
