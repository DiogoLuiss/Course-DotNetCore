using byteBankADM.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.InternalSystem
{
    public interface IAuthenticate 
    {
   
        string password { get; set; }
         string login { get; set; }

        bool  AuthFunc(string password, string login);
        
    }
}
