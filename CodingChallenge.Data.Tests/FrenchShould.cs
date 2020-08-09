using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Languages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class FrenchShould
    {
        [TestCase]
        public void Return_Square_String_In_French_And_In_Singular()
        {
            Assert.AreEqual("Carré", new French().GetShapeName(ShapeTypes.Square, 1));
        }

        [TestCase]
        public void Return_Squares_String_In_French_And_In_Plural()
        {
            Assert.AreEqual("Carrés", new French().GetShapeName(ShapeTypes.Square, 2));
        }

        [TestCase]
        public void Return_Triangle_String_In_French_And_In_Singular()
        {
            Assert.AreEqual("Triangle", new French().GetShapeName(ShapeTypes.Triangle, 1));
        }

        [TestCase]
        public void Return_Triangle_String_In_French_And_In_Plural()
        {
            Assert.AreEqual("Triangles", new French().GetShapeName(ShapeTypes.Triangle, 2));
        }

        [TestCase]
        public void Return_Circle_String_In_French_And_In_Singular()
        {
            Assert.AreEqual("Cercle", new French().GetShapeName(ShapeTypes.Circle, 1));
        }

        [TestCase]
        public void Return_Circle_String_In_French_And_In_Plural()
        {
            Assert.AreEqual("Cercles", new French().GetShapeName(ShapeTypes.Circle, 2));
        }

        [TestCase]
        public void Return_Rectangle_String_In_French_And_In_Singular()
        {
            Assert.AreEqual("Rectangle", new French().GetShapeName(ShapeTypes.Rectangle, 1));
        }

        [TestCase]
        public void Return_Rectangle_String_In_French_And_In_Plural()
        {
            Assert.AreEqual("Rectangles", new French().GetShapeName(ShapeTypes.Rectangle, 2));
        }

        [TestCase]
        public void Return_Trapeze_String_In_French_And_In_Singular()
        {
            Assert.AreEqual("Trapèze", new French().GetShapeName(ShapeTypes.Trapeze, 1));
        }

        [TestCase]
        public void Return_Trapeze_String_In_French_And_In_Plural()
        {
            Assert.AreEqual("Trapèzes", new French().GetShapeName(ShapeTypes.Trapeze, 2));
        }
    }
}
