using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {

        //member variables
        public Weather weather;
        public List<Customer> customers;

        //constructor
        public Day()
        {

        }


        //member methods
        public void DisplayWeather()
        {
            Console.WriteLine("Today's weather condition is" + " " + weather.GenerateWeatherCondition());
            Console.WriteLine("Today's temperature is" + " " + weather.GenerateTemp() + "degrees Fahrenheit.");
        }
    }
}
