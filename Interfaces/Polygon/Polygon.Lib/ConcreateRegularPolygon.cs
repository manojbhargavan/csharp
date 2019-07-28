using System;

namespace Polygon.Lib
{
    public class ConcreateRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public ConcreateRegularPolygon(int numberOfSide, int length)
        {
            NumberOfSides = numberOfSide;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
