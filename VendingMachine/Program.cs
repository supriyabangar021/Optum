using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            //-------------------------------------------------------accepting coins-----------------------------------------------------------------
            string displayname = "Insert Coin";
            Console.WriteLine(displayname);
            var enterdAmount = Console.ReadLine();
            double insertedValue = Convert.ToDouble(enterdAmount);
            AcceptingCoins.AcceptCoins(insertedValue);
            Console.ReadLine();




            //----------------------------------------------------------select Product------------------------------------------------------------------

            product product = new product();         
                   
            Console.WriteLine("Select Products : {0},{1},{2}", product.cola + " $" + product.colaValue, product.chips + " $" + product.chipsValue, product.candy + " $" + product.candyValue);
            var productselected = Console.ReadLine();
            Console.WriteLine("Insert amount for product");
            double insertedAmount = Convert.ToDouble(Console.ReadLine());
            
            ProductSelected.selectProduct(productselected, insertedAmount);
            Console.ReadLine();

        }
    }
}
