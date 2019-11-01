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
        public double earnedMoneyToday;
        public double earnedMoneyTotal;
        public double moneySpentInventoryToday;
        public double moneySpentInventoryTotal;
        //constructor
        public Wallet()
        {
            money = 20;
            earnedMoneyToday = 0;
            earnedMoneyTotal = 0;
            moneySpentInventoryToday = 0;
            moneySpentInventoryTotal = 0;
        }
        


        //member methods
        public double DisplayMoney()
        {
            Console.WriteLine("You have " + money + " dollars in your wallet.");
            return money;
        }
    }
}
