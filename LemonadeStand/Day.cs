﻿using System;
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



        //member methods
        public void DisplayWeather()
        {
           Console.WriteLine(weather.GenerateWeatherCondition());
            Console.WriteLine(weather.GenerateTemp());
        }
    }
}
