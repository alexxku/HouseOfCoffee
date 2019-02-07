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
            int SC;
            int MC;
            int LC;
            int ES;
            int CS;

            foreach(Days days in (Days[]) Enum.GetValues(typeof(Days)))
            {     
                Console.WriteLine($"--------------------{days}--------------------");
                Restart:
                try
                {
                    Console.Write("\nSmall Coffee: ");
                    SC = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Medium Coffee: ");
                    MC = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Large Coffee: ");
                    LC = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Egg Sandwich: ");
                    ES = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Chicken Sandwich: ");
                    CS = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message.ToString());
                    goto Restart;
                }

                if ((SC >= 0) && (MC >= 0) && (LC >=0) && (ES >= 0) && (CS >= 0))
                {
                    DisplayGoods(SC, MC, LC, ES, CS);

                }
                else
                {
                    Console.WriteLine("Invalid Number");
                    goto Restart;
                }

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
