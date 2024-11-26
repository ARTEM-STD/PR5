using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5
{
    class Program
    {
        static void Main(string[] args)
        {
            //compare
            string st1 = "В лукаморь дуб зеленый";
            Console.WriteLine(st1);
            Console.WriteLine("Введите тескт в ручную");
            string st2 = Console.ReadLine();
            int Q = String.Compare(st1, st2);
            
            Console.WriteLine($"Правельный варианьт: {Q}");

            //eqwils
            bool R = st1.Equals(st2);
            Console.WriteLine($"Изначальный текст схож с тем что вы ввели: {R}");
            //compare ordin
            int W = String.CompareOrdinal(st1, st2);
            Console.WriteLine(W);

            //indeks off
            string str3 = "Hello World";
            int E = str3.IndexOf("World");
            Console.WriteLine($"IndexOf: {E}");

            //== =!

            bool Z = st1 == st2;
            bool X = st1 != st2;
            Console.WriteLine($"str1 == str2: {Z}");
            Console.WriteLine($"str1 != str2: {X}");

            Console.ReadLine();
        }
        
    }
}
