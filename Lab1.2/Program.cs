using System;
using static System.Console;


namespace Fun
{
    class Program
    {
        public static double Function(double n)
        {
            return Math.Sqrt(Math.Log(4.0 / n)) - (1.0 / n) - Math.Exp(Math.Sin(n));
        }
        static void Main(string[] args)
        {
            for (int i = 0; true; i++)
            {
                double g = 0;
                WriteLine("Введите значение : ");
                try
                {
                    if (!double.TryParse(ReadLine(), out g)) throw new FormatException("Вы ввели недопустимое значение( \nПопробуйте еще раз)");
                    try
                    {
                        if (g > -1 && g < 5 && g != 0) WriteLine("\nЗначение функции = {0}", Function(g));
                        else throw new ArithmeticException("Введите другое значение\n");
                    }
                    catch (ArithmeticException)
                    {
                        WriteLine("НЕ подходит\nВведите другое значение\n");
                    }
                    catch (Exception)
                    {
                        WriteLine("Что то пошло не так\nВведите другое значение\n");
                    }
                }
                catch (FormatException)
                {
                    WriteLine("Введите число!");
                }
            }
        }
    }
}
