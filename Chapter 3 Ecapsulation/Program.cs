using System.Diagnostics;

namespace Chapter_3_Ecapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            SmoothFoxTerrier bob = new SmoothFoxTerrier("bob", 5, "Ball");

            Console.WriteLine(bob.Name);
            Console.WriteLine(SmoothFoxTerrier.Energy);

            Console.WriteLine(bob.FavoriteToy);
            bob.FavoriteToy = "Boomerang";
            Console.WriteLine(bob.FavoriteToy);

            Console.WriteLine(bob.WatchdogAbility);
            bob.WatchdogAbility = -15;
            Console.WriteLine(bob.WatchdogAbility);

            Console.WriteLine($"Protection score is : {bob.ProtectionScore}");
            */

            MutableVector vec1 = MutableVector.OriginVector();
            vec1.Sum(24, 13, -5);
            Console.WriteLine($"X:{vec1.X} Y:{vec1.Y} Z:{vec1.Z}");

            ImmutableVector vec2 = new ImmutableVector(3, 4, 5);
            ImmutableVector vec3 = vec2.sum(5, 4, 3);
            Console.WriteLine($"X:{vec2.X} Y:{vec2.Y} Z:{vec2.Z}");
            Console.WriteLine($"X:{vec3.X} Y:{vec3.Y} Z:{vec3.Z}");


        }
    }
}
