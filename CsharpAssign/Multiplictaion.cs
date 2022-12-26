using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign
{
    public class Multiplictaion
    {
       public static void Mul()
        {
            int i, j, K;
            int num = 5;
            for (i = 1; i <= 30; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num * i);
            }
            Console.WriteLine("**********Even Numbers*************");
            for (j = 1; j <= 30; j++)
            {

                if (j % 2 == 0)
                {
                    Console.WriteLine(num + "*" + j + "=" + num * j);

                }
            }
            Console.WriteLine("*********Odd Numbers**********");
            for (K = 1; K <= 30; K++)
            {
                if (K % 2 != 0)
                {
                    Console.WriteLine(num + "*" + K + "=" + num * K);
                }
            }
            Console.WriteLine();
            int sum = 0;

            for (j = 1; j <= 150; j += 5)
            {
                if (j % 2 == 0)
                {
                    sum = sum + j;
                }
            }
            Console.WriteLine("Sum of Even Number is: " + sum);


            Console.WriteLine();
            for (K = 0; K <= 150; K += 5)
            {
                if (K % 2 == 0)
                {
                    sum = sum + K;
                }
            }
            Console.WriteLine("Sum of Odd Number is: " + sum);
        }
    }
}
