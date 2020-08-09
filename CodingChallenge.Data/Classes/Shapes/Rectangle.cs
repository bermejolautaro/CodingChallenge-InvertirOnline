using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Rectangle : IShape
    {
        public Rectangle(decimal sideA, decimal sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public decimal SideA { get; }
        public decimal SideB { get; }

        public decimal CalculateArea()
        {
            return SideA * SideB;
        }

        public decimal CalculatePerimeter()
        {
            return SideA * 2 + SideB * 2;
        }

        public ShapeTypes GetShapeType()
        {
            return ShapeTypes.Rectangle;
        }
    }
}
