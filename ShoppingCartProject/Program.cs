

namespace Maveric.Runners
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------------- Shopping Cart -------------");

            Shopping Cart1 = new Shopping(4);
            Shopping Cart2 = new Shopping(5);
            Shopping Cart3 = new Shopping(7);
            Shopping Cart4 = new Shopping(4);
            Shopping Cart5 = new Shopping(2);

            Cart1.Id = 101;
            Cart1.descr = "HP";
            Cart1.Quantity = 5;
            Cart1.price = 45000;

            Cart2.Id = 102;
            Cart2.descr = "Lenovo";
            Cart2.Quantity = 8;
            Cart2.price = 70000;

            Cart3.Id = 103;
            Cart3.descr = "Apple";
            Cart3.Quantity = 9;
            Cart3.price = 49000;

            Cart4.Id = 104;
            Cart4.descr = "Dell";
            Cart4.Quantity = 15;
            Cart4.price = 50000;

            Cart5.Id = 105;
            Cart5.descr = "Acer";
            Cart5.Quantity = 7;
            Cart5.price = 90000;

            Cart1.PrintShoppintCartDetails();
            Cart2.PrintShoppintCartDetails();
            Cart3.PrintShoppintCartDetails();
            Cart4.PrintShoppintCartDetails();
            Cart5.PrintShoppintCartDetails();

            Cart1.PrintDiscountPrice();
            Cart2.PrintDiscountPrice();
            Cart3.PrintDiscountPrice(); 
            Cart4.PrintDiscountPrice();
            Cart5.PrintDiscountPrice();


        }
    }
}