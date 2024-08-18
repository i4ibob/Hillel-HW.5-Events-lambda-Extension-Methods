using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillel_HW._5_Events__lambda__Extension_Methods
{

    // Створіть делегат TemperatureChangedEventHandler, який прийматиме параметри для нової температури.
    public delegate void TemperatureChangedEventHandler(object sender, TemperatureChangedEventArgs e);

    // Класс для передачи параметров температуры
    public class TemperatureChangedEventArgs : EventArgs
    {
        public double NewTemperature { get; set; }

        public TemperatureChangedEventArgs(double newTemperature)
        {
            NewTemperature = newTemperature;
        }
    }

    // Класс термостата
    public class Thermostat
    {
        // Реалізуйте подію TemperatureChanged у класі Thermostat.
        public event TemperatureChangedEventHandler? TemperatureChanged;

        private double currentTemperature;

        // Додайте метод для зміни температури, який викликатиме подію.
        public void SetTemperature(double newTemperature)
        {
            if (newTemperature != currentTemperature)
            {
                currentTemperature = newTemperature;
                OnTemperatureChanged(newTemperature);
            }
        }

        // Вызов события TemperatureChanged
        protected virtual void OnTemperatureChanged(double newTemperature)
        {
            TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(newTemperature));
        }
    }




}
