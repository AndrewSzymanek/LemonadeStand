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
        //public double Money
        //{
        //    get
        //    {
        //        return money;
        //    }
        //    set
        //    {

        //    }
        //}
        //Add money property and use get/set to be able to keep track of profits/losses somehow?


        //constructor
        public Wallet()
        {
            money = 20;
        }
        


        //member methods
        public double DisplayMoney()
        {
            Console.WriteLine("You have " + money + " dollars in your wallet.");
            return money;
        }
    }
}
