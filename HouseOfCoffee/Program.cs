using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseOfCoffeeLibrary;

namespace HouseOfCoffee
{
    class Program
    {
        enum Days {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}
        static Payroll labor = new Payroll(1);
        static Sales sales = new Sales(0);
        static Cost cost = new Cost(0);
        static Result result = new Result(0);

        static void Main(string[] args)
        {
            foreach(Days days in (Days[]) Enum.GetValues(typeof(Days)))
            {     
                Console.WriteLine($"--------------------{days}--------------------");
                Console.Write("\nSmall Coffee: ");
                int SC = Convert.ToInt32(Console.ReadLine());
                Console.Write("Medium Coffee: ");
                int MC = Convert.ToInt32(Console.ReadLine());
                Console.Write("Large Coffee: ");
                int LC = Convert.ToInt32(Console.ReadLine());
                Console.Write("Egg Sandwich: ");
                int ES = Convert.ToInt32(Console.ReadLine());
                Console.Write("Chicken Sandwich: ");
                int CS = Convert.ToInt32(Console.ReadLine());

                DisplayGoods(SC, MC, LC, ES, CS);

                Console.WriteLine("---Worker's Punch-In Hours---\n");
                labor.PayCalc();
                Console.WriteLine($"Team Accumulated Pay: {labor.TeamPay():c}");            
                Console.WriteLine();

                result.WeeklyMatthewPay(labor.MatthewPay());
                result.WeeklySarahPay(labor.SarahPay());
                result.WeeklyLeahPay(labor.LeahPay());
                result.WeeklyVanessaPay(labor.VanessaPay());
                result.WeeklyFrankPay(labor.FrankPay());    
               
            }

            result.DisplayWeek();



            Console.ReadLine();
        }

        static void DisplayGoods(int SC, int MC, int LC, int ES, int CS)
        {
            Console.Write($"\nTotal Sales of Small Coffee : {sales.TotalSmallCoffee(SC):c}");
            Console.Write($"\nTotal Cost of Small Coffee: {cost.TotalSmallCoffee(SC):c}");
            Console.Write($"\nTotal Sales of Medium Coffee: {sales.TotalMediumCoffee(MC):c}");
            Console.Write($"\nTotal Cost of Medium Coffee: {cost.TotalMediumCoffee(MC):c}");
            Console.Write($"\nTotal Sales of Large Coffee: {sales.TotalLargeCoffee(LC):c}");
            Console.Write($"\nTotal Cost of Large Coffee: {cost.TotalLargeCoffee(LC):c}");
            Console.Write($"\nTotal Sales of Coffee: {sales.TotalSalesCoffee():c}");
            Console.Write($"\nTotal Cost of Coffee: {cost.TotalCostCoffee():c}");
            Console.Write($"\nTotal Sales of Egg Sandwiches: {sales.TotalEggSandwich(ES):c}");
            Console.Write($"\nTotal Cost of Egg Sandwiches: {cost.TotalEggSandwich(ES):c}");
            Console.Write($"\nTotal Sales of Chicken Sandwiches: {sales.TotalChickenSandwich(CS):c}");
            Console.Write($"\nTotal Cost of Chicken Sandwiches: {cost.TotalChickenSandwich(CS):c}");
            Console.Write($"\nTotal Sales of Sandwiches: {sales.TotalSalesSandwich():c}");
            Console.WriteLine($"\nTotal Cost of Sandwiches: {cost.TotalCostSandwich():c}");
            Console.WriteLine($"\nTotal Revenue: {sales.Revenue():c}");
            Console.WriteLine($"\nTotal Cost: {cost.TotalCost():c}");
            Console.WriteLine($"\nTotal Profit: {sales.Revenue() - cost.TotalCost():c}");
            Console.WriteLine();

            result.WeeklyRevenue(sales.Revenue());
            result.WeeklyCost(cost.TotalCost());
            result.WeeklyProfit(sales.Revenue() - cost.TotalCost());

        }


    }
}
