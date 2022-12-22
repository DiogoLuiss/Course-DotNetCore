using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.Holder
{
    public class Client
    {
        public string name;
        public string cpf;
        public string profession;

        public void GetClientInfo()
        {
            Console.WriteLine("Nome da pessoa: " + this.name);
            Console.WriteLine("cpf da pessoa: " + this.cpf);
            Console.WriteLine("Profissão da pessoa: " + this.profession);


        }

    }
}
