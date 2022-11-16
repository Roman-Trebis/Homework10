using System;

namespace Homework10Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Проверяем, является ли число палиндромом или нет
            /*
             * Палиндром - это число, которое одинаково выглядит в прямом и обратном направлении.
             * Например, 121, 53235, 4884, 5555 - это числа палиндромы.
             * Напишем программу, которая будет определять, является ли введеное пользователем число палиндромом или нет.
			 * Алгоритм работы программы такой:
			 * сначала она вычислит обратное число, а потом сравнит его с исходным числом. Если они одинаковые, то число является палиндромом.
             */

            long n, reversed = 0, remainder, original;
            Console.Write("Введите любое целое число: ");
            //n = int.Parse(Console.ReadLine());
            n = Convert.ToInt64(Console.ReadLine());

            original = n;

            //вычесляем обратное число
            while(n != 0)
            {
                remainder = n % 10;
                reversed = reversed * 10 + remainder;
                n /= 10;
            }

            //палиндром, если исходное число и обратное одинаковые
            if (original == reversed)
                Console.WriteLine($"{original} - палиндром");
            else
                Console.WriteLine($"{original} - не палиндром");
            Console.ReadLine();
        }
    }
}