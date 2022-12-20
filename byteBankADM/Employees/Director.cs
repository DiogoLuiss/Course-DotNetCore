using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Employees
{
    public class Director : Members
    {


        public static int AllDirector { get; private set; }
        public override double Salarybonus()
        {

            return this.salary + base.Salarybonus();
        }
        public override void SalaryIncrease()

        { this.salary *= 1.15; }


        public Director(string cpf, double salary):base(cpf, salary)
        {
            AllDirector++;
        }


    }


    
}
