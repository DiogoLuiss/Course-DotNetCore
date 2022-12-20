using byteBank.Bills;
using byteBank.Holder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    internal class Program
    {
        static void Main(string[] args)  
        {
            CurrentAccount Diogoaccount = new CurrentAccount(19);
            Client ClientDiogo = new Client();
            ClientDiogo.name = "Diogo Luis";
            ClientDiogo.cpf = "12345678";
            ClientDiogo.profession = "Programador";
   
            Diogoaccount.holder = ClientDiogo;
            Console.WriteLine("Total de contas " + CurrentAccount.CountAccount) ;
            Diogoaccount.account = "1010-x";

            Diogoaccount.SetBalanceValue(1000);

            Diogoaccount.Tel = 20;
          
            Console.WriteLine("O Tel é " + Diogoaccount.Tel);
            Console.WriteLine("Minha Altura é " + Diogoaccount.Height);


            Console.WriteLine("Os dados da minha conta são ");
            Console.WriteLine("Saldo do Diogo é: " + Diogoaccount.GetBalanceValue());
            //Console.WriteLine("Codigo da conta: " + Diogoaccount.account);
            Console.WriteLine("Numero da agencia: " + Diogoaccount.numberAgency);
            //Console.WriteLine("Titular: " + Diogoaccount.holder);


            CurrentAccount Jairoaccount = new CurrentAccount(20);
            Client ClientJairo = new Client();
            ClientJairo.name = "Jairo";
            ClientJairo.cpf = "14447";
            ClientJairo.profession = "Programador";
            Console.WriteLine("Total de contas " + CurrentAccount.CountAccount);
            Jairoaccount.SetBalanceValue(0);
            Jairoaccount.holder = ClientJairo;
           
            Jairoaccount.account = "1010-x";
 
            Console.WriteLine("Saldo do Jairo é: " + Jairoaccount.GetBalanceValue());
            Jairoaccount.Deposit(100);

            Console.WriteLine("Após chamar o metodo o valor do saldo do Jairo é = " +   Jairoaccount.GetBalanceValue());

            //if (Jairoaccount.Withdraw(100))
            //{

            //    Console.WriteLine("Saque realizado com sucesso");
            //}
            //else
            //{
            //    Console.WriteLine("Saldo insuficiente");
            //}

          

            if (Diogoaccount.Transfer(900, Jairoaccount))
            {
             
                Console.WriteLine("Tranferencia realizada");
                Console.WriteLine("Após a transferencia o valor da conta no Diogo é " + Diogoaccount.GetBalanceValue());
                Console.WriteLine("Após a transferencia o valor da conta do Jairo é " + Jairoaccount.GetBalanceValue());
            }
            else
            {
                Console.WriteLine("Tranferencia Negada");
            }
            Diogoaccount.ShowInfoAccount();
            Jairoaccount.ShowInfoAccount();

            Console.ReadKey(true);
      
        }
    }
}
