using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank.FileHandling
{
    public class FileReader
    {

        public string file { get; }

        public void Reader()
        {
            Console.WriteLine("Abrindo arquivo: " + file);

        }

        public void NextLine()
   
        {
          
            Console.WriteLine("Lendo Proxima Linha...");
            throw new IOException();

        }
        public void CloseFile()
        {
            Console.WriteLine("Fechando arquivo.");
        }
       public FileReader(string file)
        {
            this.file = file;
        }

    }
}
