using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        //member variables
        public double money;
        public double earnedMoney;
        public double moneySpentInventory;

        //constructor
        public Wallet()
        {
            money = 20;
            earnedMoney = 0;
            moneySpentInventory = 0;
        }
        


        //member methods
        public double DisplayMoney()
        {
            Console.WriteLine("You have " + money + " dollars in your wallet.");
            return money;
        }
    }
}
