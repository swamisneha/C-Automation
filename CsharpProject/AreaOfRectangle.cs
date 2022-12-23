using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCS
{
    public class AreaOfRectangle
    {

        public static double AreaOfCircle(int r)
        {
            double output = 3.14 * r * r;
            return output;
        }

        public static double AreaOfRectanle(double length, double width)
        {
            return length * width;
        }

    }
}
