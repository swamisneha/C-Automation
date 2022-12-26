using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign
{
    public class EvenOdd
    {
       public static void M1()
        {
            int i = 0;
            Console.WriteLine("Even Numbers: ");
            for (i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
            int j = 0;
            Console.WriteLine("Odd Numbers: ");
            for (j=1; j<=30; j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j + " ");
                }
            }
        }
        }

 }

