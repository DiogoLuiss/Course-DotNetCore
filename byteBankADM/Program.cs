
using byteBankADM.Employees;
using byteBankADM.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Members Antonio = new Members("12345678", 1200); // isso se chama instanciar, quando preparamos a class para utiliza-la
      
            Antonio.name = "Antonio Rosa"; //itens dessa class
      
            Console.WriteLine(Antonio.name = "Antonio Rosa");
            Console.WriteLine(Antonio.salary);
            Console.WriteLine(Antonio.Salarybonus());
            Console.WriteLine("O total de membros é " + Members.AllMembers);


            Director Diogo = new Director("12345678", 5000); 

            Diogo.name = "Diogo Luis";
          


            Console.WriteLine(Diogo.name);
            Console.WriteLine(Diogo.salary);
            Console.WriteLine("Bonus Slario " +  Diogo.Salarybonus()); //Posso chamar metodos.
            Console.WriteLine("O total de membros é " + Members.AllMembers);
            BonusManager manager = new BonusManager(); // e chamar metotos que esperam uma class inteira como parametro
            manager.Register(Diogo);
            manager.Register(Antonio);

            Console.WriteLine("O total de diretores é " + Director.AllDirector);


            Console.WriteLine("Total de Bonus " + manager.GetAllBonus);


            Diogo.SalaryIncrease();
            Antonio.SalaryIncrease();

            Console.WriteLine("Novo salario do Diogo " + Diogo.salary);
            Console.WriteLine("Novo salario do Antonio " + Antonio.salary);


            Console.ReadKey(true);
        }
    }
}
