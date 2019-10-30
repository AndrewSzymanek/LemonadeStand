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
            Console.WriteLine("Choose the amount of lemons you'd like to use in each pitcher of lemonade.");
            amountOfLemons = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Choose the amount of sugar cubes you'd like to use each pitcher of lemonade.");
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Choose the amount of ice cubes you'd like to use in each pitcher of lemonade.");
            amountOfIceCubes = Int32.Parse(Console.ReadLine());
        }
        public void SetPrice()
        {
            Console.WriteLine("Set the price per cup of lemonade.");
            pricePerCup = Double.Parse(Console.ReadLine());
            //handle user error here
        }
    }
}
