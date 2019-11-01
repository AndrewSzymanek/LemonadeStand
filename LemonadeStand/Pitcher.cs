using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        //member variables
        
        public int cupsLeftInPitcher;


        //constructor
        public Pitcher()
        {
            cupsLeftInPitcher = 20;
        }

        //member methods

        public void CupPoured(Player player)
        {
            if (player.inventory.numberOfCups > 0)
            {
                player.inventory.numberOfCups--;
                cupsLeftInPitcher--;
            }
            else if(player.inventory.numberOfCups == 0)
            {
                Console.WriteLine("You're out of cups!");
            }
        }
    }
}
