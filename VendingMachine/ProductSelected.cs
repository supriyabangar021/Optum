using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class ProductSelected
    {
        public static void selectProduct(string productSelected,double insertedAmount)
        {
            product product = new product();
           // double insertedAmount = 0;
            if (productSelected == product.cola)
            {               
                //insertedAmount = Convert.ToDouble(insertedAmt);
                if (insertedAmount == product.colaValue)
                {
                    Console.WriteLine("Product Dispensed");
                    Console.WriteLine("ThankYou");
                }
                else
                {
                    Console.WriteLine("Price of product  : " + product.colaValue);
                    Console.WriteLine("Insert Coin");
                }
            }
            else if (productSelected == product.chips)
            {               
                //insertedAmount = Convert.ToDouble(insertedAmt);
                if (insertedAmount == product.chipsValue)
                {
                    Console.WriteLine("Product Dispensed");
                    Console.WriteLine("ThankYou");
                }
                else
                {
                    Console.WriteLine("Price of product : " + product.chipsValue);
                    Console.WriteLine("Insert Coin");
                }
            }
            else if (productSelected == product.candy)
            {                
                //insertedAmount = Convert.ToDouble(insertedAmt);
                if (insertedAmount == product.candyValue)
                {
                    Console.WriteLine("Product Dispensed");
                    Console.WriteLine("ThankYou");
                }
                else
                {
                    Console.WriteLine("Price of product : " + product.candyValue);
                    Console.WriteLine("Insert Coin");
                }
            }
        }
    }
}
