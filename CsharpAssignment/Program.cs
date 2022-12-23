namespace Math.VolumeFormula
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sneha Swami");

            Volume obj = new Volume();

            double result = Volume.VolumeOfSphere(12);
            Console.WriteLine("Volume of sphere is " + result);

            result = Volume.VolumeOfCuboid(10, 10, 10);
            Console.WriteLine("Volume of Cuboid is "+ result);

            result = Volume.VolumeOfCuboid(20, 20, 20);
            Console.WriteLine("Volume of Cuboid is " + result);

            result = Volume.VolumeOfCuboid(30, 30, 30);
            Console.WriteLine("Volume of Cuboid is " + result);

            string authorName = Volume.GetAuthorName();
            Console.WriteLine(authorName);

            obj.Quit(10);

        }
    }
}