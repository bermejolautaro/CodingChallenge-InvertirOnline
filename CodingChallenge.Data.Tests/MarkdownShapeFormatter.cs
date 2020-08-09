using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Languages;
using CodingChallenge.Data.Classes.ShapeFormatters;
using CodingChallenge.Data.Classes.Shapes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class MarkdownShapeFormatterShould
    {
        private readonly IShapeFormatter _shapeFormatter;

        public MarkdownShapeFormatterShould()
        {
            _shapeFormatter = new MarkdownShapeFormatter();
        }

        [TestCase]
        public void Print_Empty_List_Message_In_Spanish_When_Empty_List_Of_Shapes_And_Language_Spanish()
        {
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(Enumerable.Empty<IShape>()), new Spanish());

            Assert.AreEqual("# Lista vacía de formas!\n", result);
        }

        [TestCase]
        public void Print_Multiple_Shapes_In_English_When_Passed_Multiple_Shapes_And_Language_English()
        {
            IEnumerable<IShape> shapes = new List<IShape>
            {
                new Square(5),
                new Circle(3),
                new Triangle(4),
                new Square(2),
                new Triangle(9),
                new Circle(2.75m),
                new Triangle(4.2m)
            };

            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(shapes), new English());

           Assert.AreEqual(
                "# Shapes report\n" +
                "2 Squares | Area 29 | Perimeter 28\n" +
                "2 Circles | Area 13,01 | Perimeter 18,06\n" +
                "3 Triangles | Area 49,64 | Perimeter 51,6\n" +
                "TOTAL:\n" +
                "7 shapes Perimeter 97,66 Area 91,65",
                result);
        }
    }
}
