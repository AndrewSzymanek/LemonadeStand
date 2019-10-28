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

        public int lemon;
        public int sugarCube;
        public int iceCube;
        public int cup;

        //constructor

        public Store()
        {
            pricePerLemon = .25;
            pricePerSugarCube = .10;
            pricePerIceCube = .05;
            pricePerCup = .50;
        }

        //member methods

        public void BuyLemons()
        {
            //wallet - (how many lemons * pricePerLemon)
        }
        public void BuySugarCubes()
        {

        }
        public void BuyIceCubes()
        {

        }
        public void BuyCups()
        {

        }
    }
}
