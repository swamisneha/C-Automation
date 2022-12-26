using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.Training
{
    public class AllPrograms
    {
        static void Main(string[] args)
        {
            EvenOdd.M1();
            Console.WriteLine();

            Sequence.sequence();
            Console.WriteLine();

            SumOfDigits.sum();
            Console.WriteLine();

            Multiplication.Mul();
            Console.WriteLine();

            Rectangle.rect();
            Console.WriteLine();

            Rectangle2.rect2();
            Console.WriteLine();
        }
    }
}
