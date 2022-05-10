using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Journal : ILibrary
    {
        public void Author_name(string autor_name)
        {
            Console.WriteLine("Автор - " + autor_name);
        }

        public void Name(string name)
        {
            Console.WriteLine("название" + name);
        }

        public void Publication_year(int year)
        {
            Console.WriteLine("год издания - " + year);
        }

        public string Publisher(string publisher)
        {
            Console.WriteLine("Издание - " + publisher);
            return publisher;
        }
        public void Journal_title(string title)
        {
            Console.WriteLine("название журнала" + title);
        }
    }
}
