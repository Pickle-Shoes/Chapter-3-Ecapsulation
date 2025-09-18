using System.Diagnostics;

namespace Chapter_3_Ecapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmoothFoxTerrier bob = new SmoothFoxTerrier("bob", 5, "Ball");

            Console.WriteLine(bob.Name);
            Console.WriteLine(SmoothFoxTerrier.Energy);

            Console.WriteLine(bob.FavoriteToy);
            bob.FavoriteToy = "Boomerang";
            Console.WriteLine(bob.FavoriteToy);

            Console.WriteLine(bob.WatchdogAbility);
            bob.WatchdogAbility = 15;
            Console.WriteLine(bob.WatchdogAbility);

        }
    }
}
