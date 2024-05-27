using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet2_Q3
{
    //class- TemperatureTracker
    public class TemperatureTracker
    {
        //array
        public double[] temperature = new double[7];

        //method
        public void inputTemperatureReport()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter the temperature of the day {i+1} : ");
                temperature[i] = double.Parse(Console.ReadLine());
            }
        }

        public void displayTemperatureReport()
        {
            Console.WriteLine("\nWeekly Temperature Report,");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"The temperature of the day {i+1} : {temperature[i]}°C");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //object
            TemperatureTracker tracker = new TemperatureTracker();

            //called
            tracker.inputTemperatureReport();
            tracker.displayTemperatureReport();

            Console.ReadLine();
        }
    }
}

/*
Output-

Enter the temperature of the day 1 : 25
Enter the temperature of the day 2 : 26
Enter the temperature of the day 3 : 34
Enter the temperature of the day 4 : 45
Enter the temperature of the day 5 : 34
Enter the temperature of the day 6 : 22
Enter the temperature of the day 7 : 21

Weekly Temperature Report:
The temperature of the day 1 : 25°C
The temperature of the day 2 : 26°C
The temperature of the day 3 : 34°C
The temperature of the day 4 : 45°C
The temperature of the day 5 : 34°C
The temperature of the day 6 : 22°C
The temperature of the day 7 : 21°C
*/
