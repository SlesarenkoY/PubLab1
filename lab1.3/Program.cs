using System;

namespace Fib
{
    class Program
    {
        static int curV = 1;
        static int lastV = 1;
        static int numFib = 0;
        public static void number(uint n)
        {
            Console.WriteLine(curV);
            curV = lastV + numFib;
            numFib = lastV;
            lastV = curV;
            if (curV < n)
                number(n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Максимальный значение: ");
            try
            {
                if (!uint.TryParse(Console.ReadLine(), out uint g)) throw new ArithmeticException();
                else number(g);
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Введите число или цифру!");
            }
            catch (Exception)
            {
                Console.WriteLine("Что то пошло не так, введите другое значение!");
            }
            Console.Read();
        }
    }
}
