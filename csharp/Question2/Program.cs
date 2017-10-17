using System;

namespace Question2
{
    class Program
    {
        static int[] firstArray = new int[] { 2, 2, 4, 1 };
        static int[] secondArray = new int[] { 1, 2, 0, 2 };

        static void Main(string[] args)
        {
            Console.WriteLine("Using Linq Library: ");
            Console.WriteLine(string.Join(" ", Intersection.FindIntersectionLinq(firstArray, secondArray)));
            
            Console.WriteLine("Using Custom Intersect Logic: ");
            Console.WriteLine(string.Join(" ", Intersection.FindIntersection(firstArray, secondArray)));

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
