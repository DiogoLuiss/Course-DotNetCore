using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Employees
{
    internal class Design: Members
    {




        public override double Salarybonus() //todo metodo que pode ser reescrito dever ter esse parametro. o VirtuaL
        {

            return this.salary * 0.17;
        }
        public override void SalaryIncrease()

        { this.salary *= 1.11; }

        public Design(string cpf): base(cpf, 3000)
        {


        }

    }
}
