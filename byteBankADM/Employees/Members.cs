using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Employees
{
    public  abstract class Members : IBonus
    {

        public string name { get; set; }

        public string cpf { get; private set; }

        public double salary { get; protected set; }
        
        public static double AllMembers { get; private set; }




        public abstract void SalaryIncrease(); // colocando como abstract não preciso mexer no metodo. 

        public virtual double Salarybonus()
        {
          return  this.salary * 0.1;
        }

        public Members(string cpf, double salary)
        {
            this.cpf = cpf;
            this.salary = salary;
            AllMembers++;
        }
 


    }
}
