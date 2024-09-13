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
                    Console.WriteLine("Введите множитель a:");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите множитель b:");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{a} * {b} = {a * b}");
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
