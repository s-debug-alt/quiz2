using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input line for price
            Console.WriteLine("What is the item price");
            // input code to turn into a double variable
            double price = Convert.ToDouble(Console.ReadLine());
            // input line for tax
            Console.WriteLine("What is the sales tax");
            // input code to turn into a double variable
            double tax = Convert.ToDouble(Console.ReadLine());
            // input line for discount
            Console.WriteLine("What is the promotion discount");
            // input code to turn into a double variable
            double discount = Convert.ToDouble(Console.ReadLine());
            // caculate code for total price
            double priceAfter = (price - price * discount);
            cost
            Console.WriteLine("The total cost is ");


        }
    }
}
