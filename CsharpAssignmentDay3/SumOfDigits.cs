using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.Training
{
    public class SumOfDigits
    {
        public static void sum()
        {
            int i, sum = 0;

            for (i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of 50 Even Numver is: " + sum);
        }
    }
}
