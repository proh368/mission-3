using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите делимое a:");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите делитель b:");
                    double b = double.Parse(Console.ReadLine());
                    if (b!= 0)
                        Console.WriteLine($"{a} / {b} = {a / b}");
                    else
                        Console.WriteLine("Деление на ноль невозможно");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Введены неверные данные");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
        
    }
}
