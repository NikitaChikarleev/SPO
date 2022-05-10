using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Book : ILibrary
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

        public void Publication_city(string city)
        {
            Console.WriteLine("Город публикации - " + city);
        }
    }
}
