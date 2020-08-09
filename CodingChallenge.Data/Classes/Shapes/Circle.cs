using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Circle : IShape
    {
        public Circle(decimal radius)
        {
            Radius = radius;
        }

        public decimal Radius { get; }

        public decimal CalculateArea()
        {
            return (decimal)Math.PI * (Radius / 2) * (Radius / 2);
        }

        public decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * Radius;
        }

        public ShapeTypes GetShapeType()
        {
            return ShapeTypes.Circle;
        }
    }
}
