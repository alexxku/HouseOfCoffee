using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseOfCoffeeLibrary
{
    public struct Cost
    {
        private double smallCost, mediumCost, largeCost, eggCost, chickenCost;

        public Cost(int x)
        {
            this.smallCost = x;
            this.mediumCost = x;
            this.largeCost = x;
            this.eggCost = x;
            this.chickenCost = x;
        }


        public double TotalSmallCoffee(int SC)
        {
            this.smallCost = SC * .10;
            return this.smallCost;
        }

        public double TotalMediumCoffee(int MC)
        {
            this.mediumCost = MC * .15;
            return this.mediumCost;
        }

        public double TotalLargeCoffee(int LC)
        {
            this.smallCost = LC * .20;
            return this.smallCost;
        }

        public double TotalCostCoffee()
        {
            return this.smallCost + this.mediumCost + this.largeCost;
        }

        public double TotalEggSandwich(int ES)
        {
            this.eggCost = ES * .95;
            return this.eggCost;
        }

        public double TotalChickenSandwich(int CS)
        {
            this.chickenCost = CS * .95;
            this.chickenCost = CS * 1.20;
            return this.chickenCost;
        }

        public double TotalCostSandwich()
        {
            return this.eggCost + this.chickenCost;
        }

        public double TotalCost()
        {
            return this.smallCost + this.mediumCost + this.largeCost + this.eggCost + this.chickenCost;
        }
    }
}
