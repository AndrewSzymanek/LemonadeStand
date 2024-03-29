﻿using System;
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
            pricePerLemon = .10;
            pricePerSugarCube = .05;
            pricePerIceCube = .05;
            pricePerCup = .10;
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
                default:
                    Console.WriteLine("Please enter a choice from the list provided.");
                    WhichItemToBuy();
                break;
            }

        }
        public void SellLemons()
        {
            Console.WriteLine("How many lemons would you like to buy? Remember lemons cost $" + pricePerLemon + "." );
            try
            {
                int numLemons = Int32.Parse(Console.ReadLine());
                double totalCost = (numLemons * pricePerLemon);
                if (player.wallet.money >= totalCost)
                {
                    player.wallet.money -= totalCost;
                    player.inventory.numberOfLemons += numLemons;
                    player.wallet.moneySpentInventoryToday += totalCost;
                    player.wallet.moneySpentInventoryTotal += totalCost;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please select a number.");
            }
            
         
            
           
        }
        public void SellSugarCubes()
        {
            Console.WriteLine("How many sugar cubes would you like to buy? Remember sugar cubes cost $" + pricePerSugarCube + ".");
            try
            {
                int numSugarCubes = Int32.Parse(Console.ReadLine());
                double totalCost = (numSugarCubes * pricePerSugarCube);
                if (player.wallet.money >= totalCost)
                {
                    player.wallet.money -= totalCost;
                    player.inventory.numberOfSugarCubes += numSugarCubes;
                    player.wallet.moneySpentInventoryToday += totalCost;
                    player.wallet.moneySpentInventoryTotal += totalCost;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please select a number.");
            }
            
          
            
        }
        public void SellIceCubes()
        {
            Console.WriteLine("How many ice cubes would you like to buy? Remember ice cubes cost $" + pricePerIceCube + ".");
            try
            {
                int numIceCubes = Int32.Parse(Console.ReadLine());
                double totalCost = (numIceCubes * pricePerIceCube);
                if (player.wallet.money >= totalCost)
                {
                    player.wallet.money -= totalCost;
                    player.inventory.numberOfIceCubes += numIceCubes;
                    player.wallet.moneySpentInventoryToday += totalCost;
                    player.wallet.moneySpentInventoryTotal += totalCost;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please select a number.");
            }
            
            
        }
        public void SellCups()
        {
            Console.WriteLine("How many cups would you like to buy? Remember cups cost $" + pricePerCup + ".");
            try
            {
                int numCups = Int32.Parse(Console.ReadLine());
                double totalCost = (numCups * pricePerCup);
                if (player.wallet.money >= totalCost)
                {
                    player.wallet.money -= totalCost;
                    player.inventory.numberOfCups += numCups;
                    player.wallet.moneySpentInventoryToday += totalCost;
                    player.wallet.moneySpentInventoryTotal += totalCost;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please select a number.");
            }
            
        }
    }
}
