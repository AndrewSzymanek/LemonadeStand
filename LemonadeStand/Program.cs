﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {

            //Day day = new Day(new Random());
           


            Game game = new Game();
            game.RunGame();
            Console.ReadLine();
        }
    }
}
