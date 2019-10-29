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


        //constructor
        public Wallet()
        {
            money = 20;
        }


        //member methods
        public double DisplayMoney()
        {
            Console.WriteLine("You have" + money + " in your wallet");
            return money;
        }
    }
}
