using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.Runners
{
    public class Shopping
    {
        public int Id;
        public string descr;
        public int quantity;
        public double price;

        public void PrintShoppintCartDetails()
        {
            Console.WriteLine("Shop Id: " +Id );
            Console.WriteLine("Description: "+descr);
            Console.WriteLine("Quantity: "+quantity);
            Console.WriteLine("Price: "+price);
            Console.WriteLine("-------------------------------");
        }

        public void PrintDiscountPrice()
        {
            Console.WriteLine("Shop Id: " + Id);
            if (quantity==2)
            {
                double d =(price - (price * 10 / 100)) * quantity;
                Console.WriteLine("Final Price: "+d);
                Console.WriteLine();
            }
            else if (quantity >=3 && quantity <=5)
            {
                double d = (price - (price * 15 / 100)) * quantity;
                Console.WriteLine("Final Price: " + d);
                Console.WriteLine();    
            }
            else if(quantity > 5)
            {
                double d = (price - (price * 25 / 100)) * quantity;
                Console.WriteLine("Final Price: " + d);
                Console.WriteLine();
            }
        }
    }
}
