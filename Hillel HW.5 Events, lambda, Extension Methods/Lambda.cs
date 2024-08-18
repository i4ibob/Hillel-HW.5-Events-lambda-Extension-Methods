using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillel_HW._5_Events__lambda__Extension_Methods
{
    internal static class Lambda
    {
        //Завдання 2: Лямбда вирази

        //Опис: Напишіть програму, яка дозволить користувачу фільтрувати список цілих чисел за допомогою лямбда виразів.
        //Вимоги:
        //Створіть список цілих чисел.
        public static void RunList()
        {
            List<int> ints = new List<int>();
            Console.WriteLine("Введите начальное число для заполнение списка ");
            var firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечное  число для заполнение списка ");
            var lastNum = Convert.ToInt32(Console.ReadLine());
            for (int i = firstNum; i <= lastNum; i++)
            {
                ints.Add(i);
            }

            //Напишіть лямбда вираз для фільтрації всіх чисел, які є парними.
            var integers = ints.Where(x => x % 2 == 0);



            //Напишіть лямбда вираз для фільтрації всіх чисел, які більше ніж задане користувачем значення.
            Console.Write("введите число для того чтоб увидеть все числа которые больше заданного:");
            var chosenNum = Convert.ToInt32(Console.ReadLine());
            var highestNums = ints.Where(x => x > chosenNum);

            //Виведіть результати фільтрації на екран.
            Console.WriteLine("четные числа списка:");
            foreach (int i in integers)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine("\nЧисла которые больше заданного: ");
            foreach (int i in highestNums) { Console.Write(i + " "); }

        }


    }
}
