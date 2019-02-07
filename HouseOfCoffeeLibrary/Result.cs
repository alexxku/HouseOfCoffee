using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseOfCoffeeLibrary
{
    public struct Result
    {
        private double WeekProfit;
        private double WeekCost;
        private double WeekRevenue;
        private double MatthewPay;
        private double SarahPay;
        private double LeahPay;
        private double VanessaPay;
        private double FrankPay ;
        private double TeamPay;

        public Result(int x)
        {
            this.WeekProfit = x;
            this.WeekCost = x;
            this.WeekRevenue = x;
            this.MatthewPay = x;
            this.SarahPay = x;
            this.LeahPay = x;
            this.VanessaPay = x;
            this.FrankPay = x;
            this.TeamPay = x;
        }

        public void DisplayWeek()
        {
            Console.WriteLine("------Weekly Report------\n");
            Console.WriteLine($"Weekly Revenue: { WeekRevenue:c}");
            Console.WriteLine($"Weekly Cost: { WeekCost:c}");
            Console.WriteLine($"Weekly Profit: { WeekProfit:c}");
            Console.WriteLine($"Matthew's Weekly Pay: {MatthewPay:c}");
            Console.WriteLine($"Sarah's Weekly Pay: {SarahPay:c}");
            Console.WriteLine($"Leah's Weekly Pay: {LeahPay:c}");
            Console.WriteLine($"Vanessa's Weekly Pay: {VanessaPay:c}");
            Console.WriteLine($"Frank's Weekly Pay: {FrankPay:c}");
            Console.WriteLine($"Team's Weekly Revenue: {TeamPay:c}");
        }

        public void WeeklyProfit(double x)
        {
            this.WeekProfit += x;
        }
        public void WeeklyCost(double x)
        {
            this.WeekCost += x;
        }
        public void WeeklyRevenue(double x)
        {
            this.WeekRevenue += x;
        }
        public void WeeklyMatthewPay(double x)
        {
            this.MatthewPay += x;
        }
        public void WeeklySarahPay(double x)
        {
            this.SarahPay += x;
        }
        public void WeeklyLeahPay(double x)
        {
            this.LeahPay += x;
        }
        public void WeeklyVanessaPay(double x)
        {
            this.VanessaPay += x;
        }
        public void WeeklyFrankPay(double x)
        {
            this.FrankPay += x;
        }
        public void WeeklyTeamPay(double x)
        {
            this.TeamPay += x;
        }

    }
    
}
