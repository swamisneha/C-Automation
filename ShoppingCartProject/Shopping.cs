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
        private int _quantity;
        public double price;

        //public Shopping() 
        //{
        //   _quantity = 1;
        //  Console.WriteLine("Object Created");
        //}
        
        public  Shopping(int _quantity)
        {
            this._quantity= _quantity;
        }

        public int Quantity
        {
            set
            {
                if (value > 0)
                {
                    _quantity = value;
                }
                else
                {
                    Console.WriteLine("Quantity cannot be nigative");
                }
            }
        }

        public void PrintShoppintCartDetails()
        {
            Console.WriteLine("Shop Id: " + Id);
            Console.WriteLine("Description: " + descr);
            Console.WriteLine("Quantity: " + _quantity);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("-------------------------------");
        }

        public void PrintDiscountPrice()
        {
            Console.WriteLine("Shop Id: " + Id);
            if (_quantity == 2)
            {
                double d = (price - (price * 10 / 100)) * _quantity;
                Console.WriteLine("Final Price: " + d);
                Console.WriteLine();
            }
            else if (_quantity >= 3 && _quantity <= 5)
            {
                double d = (price - (price * 15 / 100)) * _quantity;
                Console.WriteLine("Final Price: " + d);
                Console.WriteLine();
            }
            else if (_quantity > 5)
            {
                double d = (price - (price * 25 / 100)) * _quantity;
                Console.WriteLine("Final Price: " + d);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No Discount...!!!");
            }
        }
    }
}
