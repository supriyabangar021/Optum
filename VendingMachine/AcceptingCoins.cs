using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class AcceptingCoins
    {
        public static void AcceptCoins(double enteredAmount)
        {
            coins Coins = new coins();
            Coins.nickels = 0.05;
            Coins.dimes = 0.1;
            Coins.quarters = 0.25;
            Coins.pennies = 0.01;

            double amount = 0;
            double coinReturn = 0;
            Console.WriteLine("Current Amount" + amount);           
           
            if (enteredAmount.Equals(Coins.nickels) || enteredAmount.Equals(Coins.dimes) || enteredAmount.Equals(Coins.quarters))
            {
                amount = amount + enteredAmount;
                Console.WriteLine("Current Amount" + amount);
            }
            else if (enteredAmount.Equals(Coins.pennies))
            {
                coinReturn = enteredAmount;
                Console.WriteLine("inserted coin invalid : " + coinReturn);
            }          

        }
    }
}
