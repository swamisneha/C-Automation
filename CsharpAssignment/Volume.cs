using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.VolumeFormula
{
    public class Volume
    {
        public static double VolumeOfSphere(double radius)
        {
            return (4 * 3.14 * radius * radius) / 3;
        }
        public static double VolumeOfCuboid(double length,double width, double height)
        {
            return length * width * height;
        }
        public static double VolumeOfCylinder(double radius,double height)
        {
            return 3.1 * radius * radius * height;
        }

        public static string GetAuthorName()
        {
            return "Sneha Swami";
        }

        public void Quit(int a)
        {

        }
    }
}
