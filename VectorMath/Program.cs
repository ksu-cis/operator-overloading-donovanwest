using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(5, 4, 3);
            Vector3 two = new Vector3(2, 8, 6);

            Console.WriteLine("Adding two vectors: ");
            Console.WriteLine($"With a static method: {Vector3.Add(one, two)}");
           // one.Add(two);
            //Console.WriteLine($"With a class method: {one}");
            Console.WriteLine($"With + operator Overload: {one+two}");
            Console.WriteLine($"With - operator Overload: {one - two}");
            Console.WriteLine($"With * operator Overload: {5 * two}");
            Console.WriteLine($"Vector Comparison: {one == two}");

        }
    }
}
