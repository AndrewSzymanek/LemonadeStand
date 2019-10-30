using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {

        //member variables
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public int numberOfCups;


        //constructor
        public Inventory()
        {
            numberOfLemons = 0;
            numberOfSugarCubes = 0;
            numberOfIceCubes = 0;
            numberOfCups = 0;
        }


        //member methods
        public void DisplayInventory()
        {
            Console.WriteLine("You have " + numberOfLemons + " lemons.");
            Console.WriteLine("You have " + numberOfSugarCubes + " sugar cubes.");
            Console.WriteLine("You have " + numberOfIceCubes + " ice cubes.");
            Console.WriteLine("You have " + numberOfCups + " cups.");
        }

        //each time a pitcher is made, subtract each of these numbers by the numbers in the recipe
        //likewise, each time a visit to the store is made, add to each of these numbers

    }
}
