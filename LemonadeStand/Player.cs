using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;


        //constructor

        public Player()
        {
            ChooseName();
            wallet = new Wallet();
            inventory = new Inventory();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        //member methods

        public void ChooseName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
        }
        public void MakePitcher()
        {
            inventory.numberOfLemons -= recipe.amountOfLemons;
            inventory.numberOfSugarCubes -= recipe.amountOfSugarCubes;
            inventory.numberOfIceCubes -= recipe.amountOfIceCubes;

        }
      

    }
}
