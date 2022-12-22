using byteBank.Exceptions;
using byteBank.Holder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace byteBank.Bills
{
    public class CurrentAccount
    {

        public static int CountAccount { get; private set; }
        public static double HandlingFee { get; private set; }

        public int WithdrawalCounterNotAllowed { get; private set; }
        public int numberAgency { get; }

        public string account;

        private double balance = 100;

        private int tel = 10;
        public int Tel
        {
            get { return this.tel; }
            set
            {
                if (value > 10)
                {
                    this.tel = value;
                };
            }
        } //Jeito de restringir a propriedade.

        public Client holder;
        public void Deposit(double value)
        {

            this.balance = balance + value;

        }



        public void Withdraw(double value)


        {
            try
            {
                if (this.balance - value > 0)
                {
                    this.balance = balance - value;

                }
                else
                {
                    WithdrawalCounterNotAllowed++;
                    throw new InsufficientBalanceException("Saldo insuficiente para saque no valor de R$" + value);
                }
            }
            catch (InsufficientBalanceException Error)
            {

                throw new AccountOperationException("Operação Negada.", Error);
            }


        }



        public bool Transfer(double value, CurrentAccount destiny)
        {
            if (this.balance < value)
            {
                return false;
            }
            else
            {
                this.Withdraw(value);
                destiny.Deposit(value);
                return true;
            }
        }

        public void ShowInfoAccount()
        {

            Console.WriteLine("Conta :" + this.account);
            Console.WriteLine("Número Agência :" + this.numberAgency);
            Console.WriteLine("Saldo :" + this.balance);
            this.holder.GetClientInfo();
        }
        public void SetBalanceValue(double value)
        {
            if (value > 0)
            {
                this.balance = value;
            }
            else
            {
                return;
            }

        }
        public double GetBalanceValue()
        {
            return this.balance;


        }
        public CurrentAccount(int NumberAgency) //Meotodo construtor
        {
            if (NumberAgency <= 0)
            {

                throw new ArgumentException("O numero da Agencia deve ser maior que 0", nameof(NumberAgency));
            }
            numberAgency = NumberAgency;


            try
            {
                HandlingFee = 0 * 0;

            }
            catch (Exception Error)
            {
                Console.WriteLine("Error: " + Error.Message);

            }
            CountAccount++;

        }




    }



}
