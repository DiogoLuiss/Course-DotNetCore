using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Employees
{
    public class Members
    {

        public string name { get; set; }

        public string cpf { get; private set; }

        public double salary { get; protected set; }
        
        public static double AllMembers { get; private set; }


        public virtual double Salarybonus() //todo metodo que pode ser reescrito dever ter esse parametro. o VirtuaL
        {

            return this.salary * 0.1;
        }

        public virtual void SalaryIncrease()

        { this.salary *= 1.10;  }

      public Members(string cpf, double salary)
        {
            this.cpf = cpf;
            this.salary = salary;
            AllMembers++;
        }



    }
}
