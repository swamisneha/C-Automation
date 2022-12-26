using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign
{
    public class Rectangle
    {
        public static void rect()
        {
            int length=10;
            int width=5;
            for(int i = 0; i <=length; i++)
            {
                Console.WriteLine();
                for(int j=0; j <=width; j++)
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
