using byteBank.Holder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Bills
{
    public class CurrentAccount
    {
       
        public static int CountAccount { get; private set; }
        public int numberAgency { get; private set; }

        public string account;

        private double balance = 100;


        private int tel = 10;
        public int Tel
        {
            get { return this.tel; } set
            {
                if (value > 10)
                {
                    this.tel = value;
                }; } } //Jeito de restringir a propriedade.


        public double Height { get; private set; } = 10;

        public Client holder;

        public void Deposit(double value)
        {

            this.balance = balance + value;

        }
        public bool Withdraw(double value) 
        {

            if (this.balance - value > 0)
            {
                this.balance = balance - value;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Transfer(double value , CurrentAccount destiny)
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
            Console.WriteLine("Titular :" + this.holder.name + " " +  this.holder.cpf + " " + this.holder.profession);
        }
        public void SetBalanceValue( double value)
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
        public double GetBalanceValue() {
            return this.balance;
        
        
        }
        public CurrentAccount(int NumberAgency) //Meotodo construtor
        {
           this.numberAgency = NumberAgency;
            CountAccount++;
    }

  


    }



}
