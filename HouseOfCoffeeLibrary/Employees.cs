using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseOfCoffeeLibrary
{
    public struct Payroll
    {
        enum Employees  { Matthew, Sarah, Leah, Vanessa, Frank }
        private double []Pay;
        private int []totalhours;

        public Payroll(int x)
        {
            this.Pay = new double[(int)Employees.Frank + x];
            this.totalhours = new int [(int)Employees.Frank + x];
        }

        public void PayCalc()
        {
            int z;
            int count = (int)Employees.Matthew;
            Employees Names = Employees.Matthew;

            foreach (Employees employees in (Employees[]) Enum.GetValues(typeof(Employees)))
            {
                Restart:
                try
                {
                    Console.Write($"{Names}: ");
                    z = Convert.ToInt32(Console.ReadLine());
                    this.totalhours[count] += z;

                    if (this.totalhours[count] <= 40 && z >= 0)
                    {
                        this.Pay[count] = z * 12.50;
                        Console.WriteLine($"Standard Pay: {this.Pay[count]:c}\n");

                    }
                    else if (this.totalhours[count] > 40 && z >= 0)
                    {
                        this.Pay[count] = (z + .5) * 12.50;
                        Console.WriteLine($"Overtime: {this.Pay[count]:c}\n");

                    }
                    else
                    {
                        Console.WriteLine("Invalid Number");
                        goto Restart;
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message.ToString());
                    goto Restart;
                }
                count++;
                Names++;
            }
        }

        public double MatthewPay()
        {
            return this.Pay[0];
        }
        public double SarahPay()
        {
            return this.Pay[1];
        }
        public double LeahPay()
        {
            return this.Pay[2];
        }
        public double VanessaPay()
        {
            return this.Pay[3];
        }
        public double FrankPay()
        {
            return this.Pay[4];
        }
        public double TeamPay()
        {
            return this.Pay[0] + this.Pay[1] + this.Pay[2] + this.Pay[3] + this.Pay[4];
        }
    }
}
