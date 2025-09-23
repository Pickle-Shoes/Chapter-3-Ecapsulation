using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Chapter_3_Ecapsulation
{
    public class MutableVector
    {
        //properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        //Constructor

        public MutableVector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //method
        public void Sum(double deltaX, double deltaY, double deltaZ)
        {
            this.X += deltaX;
            this.Y += deltaY;
            this.Z += deltaZ;
        }

        public static MutableVector OriginVector()
        {
            return new MutableVector(0, 0, 0);
        }

    }
}
