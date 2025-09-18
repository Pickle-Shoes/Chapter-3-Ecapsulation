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
        private string _name;
        private int _watchdogAbility;
        private string _favoriteToy;


        //Contructor
        public SmoothFoxTerrier(string name, int w, string favToy)
        {
            this._name = name;
            this._watchdogAbility = w;
            this._favoriteToy = favToy;
        }

        //properties
        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string FavoriteToy
        {
            get
            {
                return _favoriteToy;
            }
            set
            {
                _favoriteToy = value;
            }
        }


    }
}
