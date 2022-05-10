using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Collection : ILibrary
    {
        public void Author_name(string autor_name)
        {
            Console.WriteLine("Автор - " + autor_name);
        }

        public void Name(string name)
        {
            Console.WriteLine("Название - " + name);
        }

        public void Publication_year(int year)
        {
            Console.WriteLine("Год издания - " + year);
        }

        public string Publisher(string publisher)
        {
            Console.WriteLine("Издание - " + publisher);
            return publisher;
        }
    }
}
