using System;

namespace Homework9Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задание 2. Вычисляем обратное число
            /*
             * Вычисление обратного числа.
             * Например, если пользователь вводит 1234,5678, 91011120 то программа возращает 4321, 8765, 2111019.
             * Алгоритм работы программы такой:
             * В цикле я вычисляю остаток от деления числа на 10
             * Постепенно формируем обратное число - постепенно умножаем его на 10 и добавляем остаток от предыдущей операции деления
            */

            long n, reversed = 0, remainder;
            Console.Write("Введите любое целое число: ");
            //n = int.Parse(Console.ReadLine());
            n = Convert.ToInt64(Console.ReadLine());

            //вычисляем число
            while(n != 0)
            {
                remainder = n % 10;
                reversed = reversed * 10 + remainder;
                n /= 10;
            }
            Console.WriteLine($"Обратное число = {reversed}");
            Console.ReadLine();
        }
    }
}