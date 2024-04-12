using System;

namespace BetterColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(123, 255, 110);
            Color color2 = new Color(100, 200, 0);
            Color color3 = new Color(10, 20, 30);


            Sphere sphere1 = new Sphere(color1, 4);
            Sphere sphere2 = new Sphere(color2, 6);
            Sphere sphere3 = new Sphere(color3, 2);

            sphere1.Throw();
            sphere1.Throw();
            sphere1.Pop();
            sphere1.Throw();


            sphere2.Pop();
            sphere2.Throw();

            sphere3.Throw();
            sphere3.Throw();
            sphere3.Throw();


            Console.WriteLine($"Times sphere number 1 ({color1}) was thrown: {sphere1.GetTimesThrown()}");

            Console.WriteLine($"Times sphere number 2 ({color2}) was thrown: {sphere2.GetTimesThrown()}");

            Console.WriteLine($"Times sphere number 3 ({color3}) was thrown: {sphere3.GetTimesThrown()}");
        }
    }
}
