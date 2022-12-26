using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.Training
{
    public class Sequence
    {
        public static void sequence()
        {
            int num = 3;
            // for (i = 3; i <=60; i+=3)
            for (int i = 1; i <= 20; i++)
            {

                Console.WriteLine(num + "*" + i + "=" + num * i);
            }
        }
    }
}
