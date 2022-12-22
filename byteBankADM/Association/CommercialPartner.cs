using byteBankADM.InternalSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Association
{
    public class CommercialPartner : IAuthenticate
    {
        public string password { get; set; }
        public string login { get; set ; }

        public bool AuthFunc(string password, string login)
        {
            return this.password == password && this.login == login;
        }

    }
}
