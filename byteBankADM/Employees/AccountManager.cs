using byteBankADM.InternalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Employees
{
    public class AccountManager: MemberAuthenticate
    {

    

        public override double Salarybonus() //todo metodo que pode ser reescrito dever ter esse parametro. o VirtuaL
        {

            return this.salary * 0.25;
        }
        public override void SalaryIncrease()

        { this.salary *= 1.5; }

        public AccountManager(string cpf):base(cpf, 4000){}

  
    }

}
