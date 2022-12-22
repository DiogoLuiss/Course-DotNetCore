
using byteBankADM.Association;
using byteBankADM.Books;
using byteBankADM.Employees;
using byteBankADM.InternalSystem;
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
            #region
            //Members Antonio = new Members("12345678", 1200); // isso se chama instanciar, quando preparamos a class para utiliza-la

            //Antonio.name = "Antonio Rosa"; //itens dessa class

            //Console.WriteLine(Antonio.name = "Antonio Rosa");
            //Console.WriteLine(Antonio.salary);
            //Console.WriteLine(Antonio.Salarybonus());
            //Console.WriteLine("O total de membros é " + Members.AllMembers);


            //Director Diogo = new Director("12345678", 5000); 

            //Diogo.name = "Diogo Luis";



            //Console.WriteLine(Diogo.name);
            //Console.WriteLine(Diogo.salary);
            //Console.WriteLine("Bonus Slario " +  Diogo.Salarybonus()); //Posso chamar metodos.
            //Console.WriteLine("O total de membros é " + Members.AllMembers);
            //BonusManager manager = new BonusManager(); // e chamar metotos que esperam uma class inteira como parametro
            //manager.Register(Diogo);
            //manager.Register(Antonio);

            //Console.WriteLine("O total de diretores é " + Director.AllDirector);


            //Console.WriteLine("Total de Bonus " + manager.GetAllBonus);


            //Diogo.SalaryIncrease();
            //Antonio.SalaryIncrease();

            //Console.WriteLine("Novo salario do Diogo " + Diogo.salary);
            //Console.WriteLine("Novo salario do Antonio " + Antonio.salary);


            //Console.ReadKey(true);
            #endregion

            BonusManager BonusManager = new BonusManager();

            Director Diogo = new Director("12345678");
            Diogo.name = "Diogo Luis";

            Console.WriteLine(Diogo.name);
            Console.WriteLine("Bonus " + Diogo.Salarybonus());

            BonusManager.Register(Diogo);

            Design Marcella = new Design("12345678");
            Marcella.name = "Marcella";

            Console.WriteLine(Marcella.name);
            Console.WriteLine("Bonus " + Marcella.Salarybonus());

            BonusManager.Register(Marcella);

            Auxiliary Antonio = new Auxiliary("12345678");
            Antonio.name = "Antonio Rosa";

            Console.WriteLine(Antonio.name);
            Console.WriteLine("Bonus " + Antonio.Salarybonus());

            BonusManager.Register(Antonio);

            AccountManager Ingrid = new AccountManager("12345678");
            Ingrid.name = "Ingrid Bonassio";

            Console.WriteLine(Ingrid.name);
            Console.WriteLine("Bonus " + Ingrid.Salarybonus());

            BonusManager.Register(Ingrid);

            Console.WriteLine("O total de funcionarios é " + Members.AllMembers);
            Console.WriteLine("O total de bonificação é " + BonusManager.GetAllBonus );


            //Book Book1 = new Book("Alice", "Aleatorio");

            //Console.WriteLine("");
            //Console.WriteLine("Informações do livro:");
            //Console.WriteLine("");

            //Book1.Author = "Machado de assis";
            //Book1.PublicationYear = 2014;
            //Book1.NumberPages = 120;
            //Book1.LiteraryStyle = "Suspense";
            //Book1.PublicationCountry = "BR";

            //Book1.ShowBookInfo();

            TestLogin();

            void TestLogin()
            {
                AccountManager Otavio = new AccountManager("12345678");
                Otavio.name = "Otavio";
                Otavio.password = "123";
                Otavio.login = "otavio@gmail.com";

                Director Fernando = new Director("1234578");
                Fernando.name = "Otavio";
                Fernando.password = "1234";
                Fernando.login = "fernando@gmail.com";


                SystemsProtocols SystemsProtocols = new SystemsProtocols();

                SystemsProtocols.login(Otavio, "123", "otavio@gmail.com");
                SystemsProtocols.login(Fernando, "1234", "fernando@gmail.com");

                CommercialPartner Google = new CommercialPartner();

                Google.login = "Google@gmail.com";
                Google.password = "123";
                SystemsProtocols.login(Google,"1234", Google.login);
            }

         



            Console.ReadKey();


        }
    }
}
