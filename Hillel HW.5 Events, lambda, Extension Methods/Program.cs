
using System;
using System.Threading.Channels;
using Hillel_HW._5_Events__lambda__Extension_Methods;
using Hillel_HW._5_Events__lambda__Extension_Methods.SubProgram_task4;

class Program
{   
    
    // Напишіть код, який підписується на цю подію та виводить повідомлення з новим значенням температури на екран.
    protected static void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine($"Событие!\nТемпература изменилась и составляет : {e.NewTemperature} градусов.");
    }
    


    protected static void MeasurementAdded(object sender , double NewMeasurement)
    {
        Console.WriteLine($"Событие!\nНовое измерение внесено , значение: {NewMeasurement}");
    }




    static void Main(string[]args)
    {

    
        // Создаем экземпляр термостата
        Thermostat thermostat = new Thermostat();

     
        Sensor sensor = new Sensor();
        double [] FromList = [];
        // Подписываемся на событие TemperatureChanged
        thermostat.TemperatureChanged += OnTemperatureChanged;

        // Подписываемся на событие MeasurementAdded
        sensor.MeasurementUpdated += MeasurementAdded;

        while (true)
        {
            Console.WriteLine(
                $"\nЗадание 1: :Экземпляр термостата (Events)\n" +
                  "Задание 2: Лямбда выражения (lambda)\n" +
                    "Задание 3:Методы расширения  (два массива разной длины )\n" +
                      "Задание 4:Комбинация  тем \n" +
                      "Введите номер подпрограммы:");
           var req = (SubPrograms)Convert.ToInt32( Console.ReadLine());
            switch (req)
            {
                case SubPrograms.Events:
                    Console.Clear();
                    // Изменяем температуру
                    Console.Write("Введите новую температуру:");
                    var newTemp = Convert.ToDouble(Console.ReadLine());
                    thermostat.SetTemperature(newTemp);

                    break;




                case SubPrograms.Lambda:
                    //2
                    Console.Clear();
                    Lambda.RunList();
                    break;



                case SubPrograms.Extension:
                    Console.Clear();
                    //Завдання 3: Методи розширення
                    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
                    int[] numbers2 = { 2, 4, 6, 8, 10, 12, 14, 16, 20 };
                    Console.Write("\nМассив 1 содержит = ");

                    foreach (int number in numbers)
                    {
                        Console.Write(number + "|");
                    }
                        Console.WriteLine("Средняя арифметическая массива = " + numbers.Average());


                    Console.Write("\nМассив 2 содержит = ");
                    foreach (int number in numbers2)
                    {
                        Console.Write(number + "|");
                    }
                         Console.WriteLine("Средняя арифметическая массива = " + numbers2.Average());

                    break;
                case SubPrograms.SubProgram:
                    Console.Clear();
                   
                    Console.Write("Введите новое измерение для занесение в массив:");
                    var NewMeasurement = Convert.ToDouble(Console.ReadLine());
                    sensor.AddMeasurement(NewMeasurement);

                    // перечисляем значения массива

                    sensor.ArrayMeasurementList.ForEach(item => Console.Write("[ "+ item +" ]"));
                    //хитрожопим
                     
                    FromList = sensor.ArrayMeasurementList.ToArray();
                    //выводим среднее значение массива
                    Console.WriteLine("\nСредняя арифметическая массива = " + FromList.Average() + "\n");
                    break;

            }

        }
        

        

        


    }

 


}



