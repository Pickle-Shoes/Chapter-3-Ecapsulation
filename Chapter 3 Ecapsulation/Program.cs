namespace Chapter_3_Ecapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmoothFoxTerrier bob = new SmoothFoxTerrier("bob", 5, "Ball");

            Console.WriteLine(bob.Name);
            Console.WriteLine(SmoothFoxTerrier.Energy);
        }
    }
}
