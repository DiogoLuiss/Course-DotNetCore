using byteBankADM.InternalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Employees
{
    public class Director : MemberAuthenticate
    {
        public override double Salarybonus()
        {

            return this.salary * 0.10;
        }
        public override void SalaryIncrease()

        { this.salary *= 1.15; }


        public Director(string cpf):base(cpf, 5000)
        {
        
        }

  

    }


    
}
