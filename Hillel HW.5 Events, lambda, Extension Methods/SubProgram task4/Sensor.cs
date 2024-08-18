using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillel_HW._5_Events__lambda__Extension_Methods.SubProgram_task4
{
    public delegate void MeasurementUpdateEventHandler(object sender, double NewMeasurement);




    internal class Sensor //Створіть клас Sensor, який міститиме масив вимірювань (типу double) та подію MeasurementUpdated.
    {

       public  List<double> ArrayMeasurementList;
        
       public event MeasurementUpdateEventHandler MeasurementUpdated;

        public Sensor()
        {
            ArrayMeasurementList = new List<double> ();
        }



        public void AddMeasurement(double newMeasurement)
        {
            Func<double, bool> isPositive = (value) => value > 0;

            if (isPositive(newMeasurement))
            {

                ArrayMeasurementList.Add(newMeasurement);
                MeasurementUpdated.Invoke(this, newMeasurement);
            }
            else
            {
                Console.WriteLine("Значение измерения должно быть положительным.");
            }
        }

    }
    }
