using byteBankADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Utils
{
    public class BonusManager
    {

        public double GetAllBonus {get; private set;} //jeito de declarar uma variavel.

        public void Register(Members Member ) 
        {
            this.GetAllBonus += Member.Salarybonus();
        }
    


    }


}
