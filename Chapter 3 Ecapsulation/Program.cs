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

        }
    }
}
