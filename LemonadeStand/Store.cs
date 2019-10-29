using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        //member variables

        public double pricePerLemon;
        public double pricePerSugarCube;
        public double pricePerIceCube;
        public double pricePerCup;

        public Player player;

        //constructor

        public Store(Player player)
        {
            pricePerLemon = .25;
            pricePerSugarCube = .10;
            pricePerIceCube = .05;
            pricePerCup = .50;

            this.player = player;
        }

        //member methods


        public void WhichItemToBuy()
        {
            Console.WriteLine("Enter which item you'd like to purchase. Enter 'lemons', 'sugar cubes', 'ice cubes', or 'cups'.");
            string storeChoice = Console.ReadLine();

            switch (storeChoice)
            {
                case "lemons":
                    SellLemons();
                break;
                case "sugar cubes":
                    SellSugarCubes();
                break;
                case "ice cubes":
                    SellIceCubes();
                break;
                case "cups":
                    SellCups();
                break;
            }

        }
        public void SellLemons()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int numLemons = Int32.Parse(Console.ReadLine());
            double totalCost = (numLemons * pricePerLemon);
            player.wallet.money -= totalCost;
            //figure out if person has enough money in wallet
            //wallet minus (how many lemons * pricePerLemon)
        }
        public void SellSugarCubes()
        {
            Console.WriteLine("How many sugar cubes would you like to buy?");
            int numSugarCubes = Int32.Parse(Console.ReadLine());
            double totalCost = (numSugarCubes * pricePerSugarCube);
            player.wallet.money -= totalCost;
        }
        public void SellIceCubes()
        {
            Console.WriteLine("How many ice cubes would you like to buy?");
            int numIceCubes = Int32.Parse(Console.ReadLine());
            double totalCost = (numIceCubes * pricePerIceCube);
            player.wallet.money = (player.wallet.money - totalCost);
        }
        public void SellCups()
        {
            Console.WriteLine("How many cups would you like to buy?");
            int numCups = Int32.Parse(Console.ReadLine());
            double totalCost = (numCups * pricePerCup);
            player.wallet.money = (player.wallet.money - totalCost);

        }
    }
}
