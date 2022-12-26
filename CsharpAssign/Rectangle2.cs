using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign
{
    public class Rectangle2
    {
        public static void rect2()
        {
            int length = 15;
            int width = 10;
            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= width; j++)
                {
                    if (i == 0 || i == length || j == 0 || j == width)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
            }
        }
    }
}
