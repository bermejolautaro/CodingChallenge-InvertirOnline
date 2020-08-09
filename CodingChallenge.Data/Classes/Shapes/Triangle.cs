using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Triangle : IShape
    {
        public Triangle(decimal side)
        {
            SideA = side;
            SideB = side;
            SideC = side;
        }

        public Triangle(decimal equalSide, decimal differentSide)
        {
            SideA = equalSide;
            SideB = equalSide;
            SideC = differentSide;

        }

        public Triangle(decimal sideA, decimal sideB, decimal sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public decimal SideA { get; }
        public decimal SideB { get; }
        public decimal SideC { get; }

        public decimal CalculateArea()
        {
            return ApplyHeronFormula(CalculatePerimeter() / 2);
        }

        private decimal ApplyHeronFormula(decimal semiperimeter)
        {
            return (decimal)Math.Sqrt((double)(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC)));
        }

        public decimal CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public ShapeTypes GetShapeType()
        {
            return ShapeTypes.Triangle;
        }
    }
}
