using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Validation
    {
        public int ValInt(int x)
        { 
            while(x<0)
            {
                Console.WriteLine("Ошибка! Число меньше 0");
                x = ValIntStr();
                x = Convert.ToInt32(Console.ReadLine());
            }
            return x;
        }
        public int ValIntStr()
        {
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Веденное значение не число, повторите ввод");
            }
            return x;
        }
        public int ValIntAge(int x)
        {
            while (x >2022)
            {
                Console.WriteLine("Ошибка! Число больше 2022");
                x = ValIntStr();
                x = Convert.ToInt32(Console.ReadLine());
            }
            return x;
        }
    public string ValString(string str)
        { 
            while(str.Length==0)
            {
                Console.WriteLine("Ошибка! Введите слово");
                str = Console.ReadLine();
            }
            return str;
        }
    }
}
