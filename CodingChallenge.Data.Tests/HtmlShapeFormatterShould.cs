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
    public class HtmlShapeFormatterShould
    {
        private readonly IShapeFormatter _shapeFormatter;

        public HtmlShapeFormatterShould()
        {
            _shapeFormatter = new HtmlShapeFormatter();
        }

        [TestCase]
        public void Print_Empty_List_Message_In_Spanish_When_Empty_List_Of_Shapes_And_Language_Spanish()
        {
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(Enumerable.Empty<IShape>()), new Spanish());

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", result);
        }

        [TestCase]
        public void Print_Empty_List_Message_In_English_When_Empty_List_Of_Shapes_And_Language_English()
        {
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(Enumerable.Empty<IShape>()), new English());

            Assert.AreEqual("<h1>Empty list of shapes!</h1>", result);
        }

        [TestCase]
        public void Print_Empty_List_Message_In_French_When_Empty_List_Of_Shapes_And_Language_French()
        {
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(Enumerable.Empty<IShape>()), new French());

            Assert.AreEqual("<h1>Liste vide de formes!</h1>", result);
        }

        [TestCase]
        public void Print_A_Square_In_Spanish_When_Passed_One_Square_And_Language_Spanish()
        {
            IEnumerable<IShape> shapes = new List<IShape>() { new Square(5) };
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(shapes), new Spanish());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 forma Perímetro 20 Área 25", result);
        }

        [TestCase]
        public void Print_A_Rectangle_In_Spanish_When_Passed_One_Rectangle_And_Language_Spanish()
        {
            IEnumerable<IShape> shapes = new List<IShape>() { new Rectangle(5, 2) };
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(shapes), new Spanish());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Área 10 | Perímetro 14 <br/>TOTAL:<br/>1 forma Perímetro 14 Área 10", result);
        }

        [TestCase]
        public void Print_Multiple_Squares_In_Spanish_When_Passed_Multiple_Squares_And_Language_Spanish()
        {
            IEnumerable<IShape> shapes = new List<IShape>() { new Square(5), new Square(1), new Square(3) };
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(shapes), new Spanish());

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Cuadrados | Área 35 | Perímetro 36 <br/>TOTAL:<br/>3 formas Perímetro 36 Área 35", result);
        }

        [TestCase]
        public void Print_Multiple_Squares_In_English_When_Passed_Multiple_Squares_And_Language_English()
        {
            IEnumerable<IShape> shapes = new List<IShape>() { new Square(5), new Square(1), new Square(3) };
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(shapes), new English());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", result);
        }

        [TestCase]
        public void Print_Multiple_Squares_In_French_When_Passed_Multiple_Squares_And_Language_French()
        {
            IEnumerable<IShape> shapes = new List<IShape>() { new Square(5), new Square(1), new Square(3) };
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(shapes), new French());

            Assert.AreEqual("<h1>Rapport de formulaires</h1>3 Carrés | Superficie 35 | Périmètre 36 <br/>TOTAL:<br/>3 formes Périmètre 36 Superficie 35", result);
        }

        [TestCase]
        public void Print_Multiple_Trapezoids_In_French_When_Passed_Multiple_Trapezoids_And_Language_French()
        {
            IEnumerable<IShape> shapes = new List<IShape>() { new Trapeze(3, 6, 4, 5), new Trapeze(4, 5, 3, 3), new Trapeze(3, 7, 5, 4.12m) };
            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(shapes), new French());

            Assert.AreEqual("<h1>Rapport de formulaires</h1>3 Trapèzes | Superficie 51,3 | Périmètre 52,12 <br/>TOTAL:<br/>3 formes Périmètre 52,12 Superficie 51,3", result);
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
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br" +
                "/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                result);
        }

        [TestCase]
        public void Print_Multiple_Shapes_In_Spanish_When_Passed_Multiple_Shapes_And_Language_Spanish()
        {
            var shapes = new List<IShape>
            {
                new Square(5),
                new Circle(3),
                new Triangle(4),
                new Square(2),
                new Triangle(9),
                new Circle(2.75m),
                new Triangle(4.2m)
            };

            var result = _shapeFormatter.FormatSummary(new ShapesCalculator(shapes), new Spanish());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Área 91,65",
                result);
        }
    }
}
