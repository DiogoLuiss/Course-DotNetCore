using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBankADM.Books
{
    public class Book
    {

        public string Title { get; private set; }
        public string Author { get; set; }
        public string ISBN { get; private set; }
        public int PublicationYear { get; set; }
        public string LiteraryStyle { get; set; }
        public int NumberPages { get; set; }
        public string PublicationCountry { get; set; }

        public Book(string Title, string ISBN)
        {
            this.Title = Title;
            this.ISBN = ISBN;
        }

     public void ShowBookInfo()
        {

            Console.WriteLine("Titulo: " +  this.Title);
            Console.WriteLine("Autor: " + this.Author);
            Console.WriteLine("ISBN: " + this.ISBN);
            Console.WriteLine("Ano de publicação: " + this.PublicationYear);
            Console.WriteLine("Tipo leterario: " + this.LiteraryStyle);
            Console.WriteLine("Numero de paginas: " + this.NumberPages);
            Console.WriteLine("Ano de publicação: " + this.PublicationCountry);

        }

    }
}
