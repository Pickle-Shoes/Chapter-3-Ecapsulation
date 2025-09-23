using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_3_Ecapsulation
{
    internal class ImmutableVector
    {
        //read-only properties
        public double X { get; private set;}
        public double Y { get; private set;}
        public double Z { get; private set;}


        //Constructor
        public ImmutableVector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        //Method
        public ImmutableVector sum(double deltaX, double deltaY, double deltaZ)
        {
            //dont overwrite values, instead create new vector with new values
            return new ImmutableVector(X + deltaX, Y + deltaY, Z + deltaZ);
        }


        //Class Mehtods
        public static ImmutableVector EqualElementsVector(double initialValue)
        {
            return new ImmutableVector(initialValue, initialValue, initialValue);
        }

        public static ImmutableVector OrginVector()
        {
            return ImmutableVector.EqualElementsVector(0);
        }

    }
}
