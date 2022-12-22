using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Employees
{
    internal class Auxiliary: Members
    {


        public override double Salarybonus()
        {

            return this.salary * 0.20;
        }
        public override void SalaryIncrease()

        { this.salary *= 1.10; }
      public  Auxiliary(String cpf): base(cpf, 2000){}

    }
}
