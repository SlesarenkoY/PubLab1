using System;
using System.Numerics;
using static System.Console;

namespace Facturial
{
    class Program
    {
        static BigInteger Fact(uint n)
        {
            if (n < 0)
                return 0;
            if (n == 0)
                return 1;
            if (n == 1 || n == 2)
                return n;
            return Prod(2, n);
        }
        static BigInteger Prod(uint left, uint right)
        {
            if (left > right)
                return 1;
            if (left == right)
                return left;
            if (right - left == 1)
                return (BigInteger)left * right;
            uint m = (left + right) / 2;
            return Prod(left, m) * Prod(m + 1, right);
        }

        static void Main(string[] args)
        {
           
           uint n = 0;
           WriteLine("Введите неотрицательное целое число:");
            while (!uint.TryParse(ReadLine(), out n))
            {
              WriteLine("Вы ввели недопустимое значение \n(Попробуйте еще раз)");
            }
            WriteLine("F({0}) = {1}", n, Fact(n));
            

            for (int g = 0; true; g++)
           {
                try
                {
                    if (!uint.TryParse(ReadLine(), out uint i)) throw new FormatException("Вы ввели недопустимое значение( \nПопробуйте еще раз)");
                    WriteLine("F({0}) = {1}", i, Fact(i));
                }
               catch (FormatException)
                {
                    WriteLine("Вы ввели недопустимое значение( \nПопробуйте еще раз)");
                }
            
        }
        }
    }
}
