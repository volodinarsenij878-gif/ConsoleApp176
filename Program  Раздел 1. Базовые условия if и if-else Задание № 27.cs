using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int lastDigit = Math.Abs(n) % 10; // Math.Abs, чтобы корректно для отрицательных
                Console.WriteLine(lastDigit == 7 ? "Последняя цифра — 7" : "Последняя цифра не 7");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}