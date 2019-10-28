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

       

        //constructor

        public Store()
        {
            pricePerLemon = .25;
            pricePerSugarCube = .10;
            pricePerIceCube = .05;
            pricePerCup = .50;
        }

        //member methods

        public void SellLemons()
        {
            //ask how many the person would like to buy
            //calculate total
            //figure out if person has enough money in wallet
            //wallet minus (how many lemons * pricePerLemon)
        }
        public void SellSugarCubes()
        {

        }
        public void SellIceCubes()
        {

        }
        public void SellCups()
        {

        }
    }
}
