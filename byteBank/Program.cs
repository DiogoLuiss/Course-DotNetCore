using byteBank.Bills;
using byteBank.Exceptions;
using byteBank.FileHandling;
using byteBank.Holder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    internal class Program
    {
        static void Main(string[] args)  
        {
            try
            {
                CurrentAccount Diogoaccount = new CurrentAccount(1);
                Client ClientDiogo = new Client();
                ClientDiogo.name = "Diogo Luis";
                ClientDiogo.cpf = "12345678";
                ClientDiogo.profession = "Programador";
                Diogoaccount.holder = ClientDiogo;
                Diogoaccount.account = "1010-x";
                Diogoaccount.SetBalanceValue(0);
                Diogoaccount.Tel = 20;
              
                Diogoaccount.Withdraw(100);
                Diogoaccount.ShowInfoAccount();
         
               

            }
            catch (ArgumentException Error)
            {

                Console.WriteLine("Error: " + Error.Message);
                Console.WriteLine("Error: " + Error.StackTrace);
      


            }
            catch(AccountOperationException Error) {
                Console.WriteLine("Error: " + Error.Message);
                Console.WriteLine("Error: " + Error.StackTrace);
                Console.WriteLine();
                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");
                Console.WriteLine(Error.InnerException.Message);
            
            }




            Console.WriteLine();



            CurrentAccount Jairoaccount = new CurrentAccount(20);
            Client ClientJairo = new Client();
            ClientJairo.name = "Jairo";
            ClientJairo.cpf = "14447";
            ClientJairo.profession = "Programador";

            Jairoaccount.SetBalanceValue(0);
            Jairoaccount.holder = ClientJairo;
           
            Jairoaccount.account = "1010-x";

            //Console.WriteLine("Saldo do Jairo é: " + Jairoaccount.GetBalanceValue());
            //Jairoaccount.Deposit(100);

            //Console.WriteLine("Após chamar o metodo o valor do saldo do Jairo é = " + Jairoaccount.GetBalanceValue());

            //if (Jairoaccount.Withdraw(100))
            //{

            //    Console.WriteLine("Saque realizado com sucesso");
            //}
            //else
            //{
            //    Console.WriteLine("Saldo insuficiente");
            //}



            //if (Diogoaccount.Transfer(900, Jairoaccount))
            //{

            //    Console.WriteLine("Tranferencia realizada");
            //    Console.WriteLine("Após a transferencia o valor da conta no Diogo é " + Diogoaccount.GetBalanceValue());
            //    Console.WriteLine("Após a transferencia o valor da conta do Jairo é " + Jairoaccount.GetBalanceValue());
            //}
            //else
            //{
            //    Console.WriteLine("Tranferencia Negada");
            //}

    
            Jairoaccount.ShowInfoAccount();
            Console.WriteLine();
        
            Console.WriteLine();

            Console.WriteLine("Total de contas " + CurrentAccount.CountAccount);
            Console.WriteLine("Valor da taxa: R$" + CurrentAccount.HandlingFee);

            Console.WriteLine();
            Console.WriteLine("Simulação de leitura de arquivos");
            Console.WriteLine();
            FileReader FileReader = new FileReader("Text.exe");
            try
            {
                FileReader.Reader();
                FileReader.NextLine();
                FileReader.NextLine();
                FileReader.NextLine();
  
            }
            catch (IOException Error)
            {
                Console.WriteLine("Exceção do tipo IOExeption capturada e tratada!");
            }finally
            {
                FileReader.CloseFile();
            }

            Console.ReadKey(true);
      
        }
    }
}
