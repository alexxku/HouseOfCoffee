using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseOfCoffeeLibrary
{
    public struct Sales
    {
        private double smallCoffee, mediumCoffee, largeCoffee, eggSandwich, chickenSandwich;

        public Sales(int x)
        {
            this.smallCoffee = x;
            this.mediumCoffee = x;
            this.largeCoffee = x;
            this.eggSandwich = x;
            this.chickenSandwich = x;
        }

        public double TotalSmallCoffee(int SC)
        {
            this.smallCoffee = SC * 1.00;
            return this.smallCoffee;
        }

        public double TotalMediumCoffee(int MC)
        {
            this.mediumCoffee = MC * 3.00;
            return this.mediumCoffee;
        }

        public double TotalLargeCoffee(int LC)
        {
            this.largeCoffee = LC * 7.50;
           return this.largeCoffee;
        }

        public double TotalSalesCoffee()
        {
            return this.smallCoffee + this.mediumCoffee + this.largeCoffee;
        }

        public double TotalEggSandwich(int ES)
        {
            this.eggSandwich = ES * 5.50;
            return this.eggSandwich;
        }

        public double TotalChickenSandwich(int CS)
        {
            this.chickenSandwich = CS * 7.50;
            return this.chickenSandwich;
        }

        public double TotalSalesSandwich()
        {
            return this.eggSandwich + this.chickenSandwich;
        }
        public double Revenue ()
        {
            return this.smallCoffee + this.mediumCoffee + this.largeCoffee + this.eggSandwich + this.chickenSandwich;
        }
    }

}
