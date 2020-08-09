using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Trapeze : IShape
    {
        public Trapeze(decimal minorBase, decimal majorBase, decimal sideA, decimal sideB)
        {
            if (minorBase >= majorBase)
                throw new ArgumentException("Minor base must be less than major base");

            if (!CheckTriangleInequality(majorBase - minorBase, sideA, sideB))
                throw new ArgumentException("Invalid trapeze.");

            MinorBase = minorBase;
            MajorBase = majorBase;
            SideA = sideA;
            SideB = sideB;
        }

        private bool CheckTriangleInequality(decimal a, decimal b, decimal c)
        {
            return a + b > c &&
                   b + c > a &&
                   c + a > b;
        }

        public decimal MinorBase { get; }
        public decimal MajorBase { get; }
        public decimal SideA { get; }
        public decimal SideB { get; }

        public decimal CalculateArea()
        {
            var height = new Triangle(MajorBase - MinorBase, SideA, SideB).CalculateArea() * 2 / (MajorBase - MinorBase);

            return height * (MajorBase + MinorBase) / 2;
        }

        public decimal CalculatePerimeter()
        {
            return MajorBase + MinorBase + SideA + SideB;
        }

        public ShapeTypes GetShapeType()
        {
            return ShapeTypes.Trapeze;
        }
    }
}
