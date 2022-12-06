using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;

            while (true)
            {
                try
                {
                    Console.Write("Введите натуральное N: ");
                    N = int.Parse(Console.ReadLine());

                    if (N <= 0) throw new Exception();

                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка: ожидается ввод натурального числа");
                }
            }

            Console.WriteLine($"Результат функции: {N/f(1, N)}");
        }

        static double f(int a, double N)
        {
            if (a == N)
            {
                return Math.Sqrt(a);
            }

            return Math.Sqrt(a + f(a + 1, N));
        }
    }
}
