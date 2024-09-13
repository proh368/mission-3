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
                    Console.WriteLine("Введите значение a:");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Выберите действие (+, -, /, *)");
                    string act = Console.ReadLine();
                    Console.WriteLine("Введите значение b:");
                    double b = double.Parse(Console.ReadLine());
                    switch (act)
                    {
                        case "+":
                            Console.WriteLine($"{a} + {b} = {a + b}");
                            break;
                        case "-":
                            Console.WriteLine($"{a} - {b} = {a - b}");
                            break;
                        case "/":
                            if (b != 0)
                                Console.WriteLine($"{a} / {b} = {a / b}");
                            else
                                Console.WriteLine("Деление на ноль невозможно");
                            break;
                        case "*":
                            Console.WriteLine($"{a} * {b} = {a * b}");
                            break;
                    }
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
