using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {

        //member variables
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;


        //constructor
        public Recipe()
        {
            
        }


        //member methods
        public void MakeRecipe()
        {
            Console.WriteLine("Choose the amount of lemons you'd like to use in your recipe.");
            amountOfLemons = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Choose the amount of sugar cubes you'd like to use in your recipe.");
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Choose the amount of ice cubes you'd like to use in your recipe.");
            amountOfIceCubes = Int32.Parse(Console.ReadLine());
        }
    }
}
