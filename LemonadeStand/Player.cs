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
            
        }

        //member methods

        public void ChooseName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
        }
        public void MakePitcher()
        {


        }
      

    }
}
