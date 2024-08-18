using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillel_HW._5_Events__lambda__Extension_Methods
{
    internal static  class Extension
    {

        //Завдання 3: Методи розширення
        //Опис: Реалізуйте метод розширення для масиву цілих чисел, який обчислюватиме середнє значення елементів масиву.
        //Вимоги:
        // Створіть клас, що містить статичний метод розширення Average для масиву цілих чисел.

        public static int Average(this int[] arr )
        {

            //Метод повинен повертати середнє значення елементів масиву.
                int sum = 0;
                foreach (int num in arr) 
                { 
                
                 sum += num;
 
                }
            return sum / arr.Length;
           
            //Використайте цей метод в основній програмі та протестуйте його на кількох масивах різної довжини.

        }

    }
}
