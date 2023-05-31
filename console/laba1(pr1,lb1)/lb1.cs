using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite 1 chislo");
            double a = Convert.ToDouble(Console.ReadLine());//вводим  1 число
            Console.WriteLine("utogo");
            Console.WriteLine("abc 1 = "+Math.Abs(c)); //ищем абсолютное значение
            Console.WriteLine("vvedite 2 chislo");
            double c = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("max 1 and 2 = " + Math.Max(a,c)); //максимальное из двух чисел
            Console.WriteLine("sqrt 1 = " + Math.Round(Math.Sqrt(a)));//корень 1 числа
            Console.WriteLine("Truncate 1 = " + Math.Truncate(a));//целая числа

            Console.WriteLine("gip cos 1 = " + Math.Round( Math.Exp(a)+ Math.Exp(-a)/2));//гиперболический корень 1 числа

        }
    }
}
