using byteBankADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.InternalSystem
{
    public class SystemsProtocols
    {

        public void login(IAuthenticate Authenticate, string password, string login )
        {

            bool userAuth = Authenticate.AuthFunc(password, login);

            if (userAuth)
            {
                Console.WriteLine("Seja bem vindo.");
            }
            else
            {
                Console.WriteLine("Usuario ou senha Incorretos.");
            }

        }
    
        }

    
}
