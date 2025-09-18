using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Ecapsulation
{
    internal class SmoothFoxTerrier
    {
        //Class fields/Attributes
        public static string Family;
        public static string AreaOfOrgin;
        public const int Energy = 10;
        public static int ColdTolerance;
        public static int HeatTolerance;
        
        //instance feild/Attributes
        public string Name;
        public int WatchdogAbility;
        public string FavoriteToy;


        //Contructor
        public SmoothFoxTerrier(string name, int w, string favToy)
        {
            this.Name = name;
            this.WatchdogAbility = w;
            this.FavoriteToy = favToy;
        }
    }
}
