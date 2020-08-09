using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Square : IShape
    {
        public Square(int side)
        {
            Side = side;
        }

        public int Side { get; }

        public decimal CalculateArea()
        {
            return Side * Side;
        }

        public decimal CalculatePerimeter()
        {
            return Side * 4;
        }

        public ShapeTypes GetShapeType()
        {
            return ShapeTypes.Square;
        }
    }
}
