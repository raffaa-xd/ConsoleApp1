using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти сумму двух целых чисел
            Console.Write($"number_1= ");
            int number_1 = int.Parse(Console.ReadLine());
            Console.Write($"number_2= ");
            int number_2 = int.Parse(Console.ReadLine());
            int sum = number_1 + number_2;
            Console.Write($"sum= {sum}");
            Console.Read();
        }
    }
}
