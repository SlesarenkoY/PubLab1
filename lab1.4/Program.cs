using System;

namespace Teylor
{
    class Program
    {
        public static ulong Factorial(int x)
        {
            ulong FactValue = 1;
            for (uint i = 1; i < x; i++)
            {
                FactValue += FactValue * i;
            }
            return FactValue;
        }
        public static double Function(int x, int n)
        {
            return (Math.Pow(x, 2 * n) / Factorial(2 * n));
        }

        static void Main(string[] args)
        {
            int x;
            double e;
            try
            {
                Console.Write("Введите значение х: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите точность вычисления e: ");
                e = Convert.ToDouble(Console.ReadLine());
                double extra = 1;
                double previous, current = 0;
                for (int i = 0; extra < e; i++)
                {
                    previous = current;
                    current = previous + Function(x, i);
                    extra = Math.Abs(current - previous);
                    Console.WriteLine("\n" + current);
                }
                Console.WriteLine("\nСумма ряда с заданной c точность {0} = {1}", e, current);
                Console.Read();
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    Console.WriteLine("Ввeдено недопустимое значение!");
                Console.Read();
            }

        }
    }
}
