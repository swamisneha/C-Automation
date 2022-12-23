

namespace ProgramCS
{
    public class Program
    {
        public static double AreaOfCircle(int r)
        {
            double output = 3.14 * r * r;
            return output;
        }
        static void Main1(string[] args)
        {
            int radius = 10;
            double result = 3.14 * radius * radius;
            Console.WriteLine(result);

            radius = 20;
            result = 3.14 * radius * radius;
            Console.WriteLine(result);

            radius = 30;
            result = 3.14 * radius * radius;
            Console.WriteLine(result);
        }
    }
}
