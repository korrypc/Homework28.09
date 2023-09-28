using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Задание 2");
            
            string s = "C# обладает эффективными средствами обработки строк";

            int f = s.IndexOf("о");
            int l = s.LastIndexOf("о");
            int a = s.IndexOf("ми");
            int b = s.LastIndexOf("ми");

            bool x = s.StartsWith("C# обладает");
            bool y = s.EndsWith("строк");


            Console.WriteLine("Индекс первого вхождения символа 'о' : "+f);
            Console.WriteLine("Индекс последнего вхождения символа 'о' : " + l);
            Console.WriteLine("Индекс первого вхождения символа 'ми' : " + a);
            Console.WriteLine("Индекс последнего вхождения символа 'ми' : " + b);
            if (x==true)
            {
                Console.WriteLine("Строка str начинается с подстроки 'C# обладает'");
            }
            else
            {
                Console.WriteLine("Автобус");
            }
            if (y == true)
            {
                Console.WriteLine("Строка str оканчивается с подстроки 'строк'");
            }
            else
            {
                Console.WriteLine("Автобус");
            }
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Задание 3");

            string s1 = "Это тест", s2;

            s2 = s1.Insert(3, " простой");
            Console.WriteLine(s2);

            Console.WriteLine("Задание 4");

            string s3 = "Это простой тест", s4;

            s4 = s3.Replace("простой", "непростой");
            Console.WriteLine(s4);

            Console.WriteLine("Задание 5");


        }
    }
}
