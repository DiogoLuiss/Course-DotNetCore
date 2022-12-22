using byteBankADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.InternalSystem
{
    public abstract class MemberAuthenticate : Members, IAuthenticate
    {
        public string password { get ; set; }
        public string login { get; set ; }


        public  bool  AuthFunc(string password, string login)
        {
          return this.password == password && this.login == login;
        }



        public MemberAuthenticate(string cpf, double salary): base(cpf,salary)
        {
         
        }

    }
}
