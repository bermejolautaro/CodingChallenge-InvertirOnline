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
    public class EnglishShould
    {
        [TestCase]
        public void Return_Square_String_In_English_And_In_Singular()
        {
            Assert.AreEqual("Square", new English().GetShapeName(ShapeTypes.Square, 1));
        }

        [TestCase]
        public void Return_Squares_String_In_English_And_In_Plural()
        {
            Assert.AreEqual("Squares", new English().GetShapeName(ShapeTypes.Square, 2));
        }

        [TestCase]
        public void Return_Triangle_String_In_English_And_In_Singular()
        {
            Assert.AreEqual("Triangle", new English().GetShapeName(ShapeTypes.Triangle, 1));
        }

        [TestCase]
        public void Return_Triangle_String_In_English_And_In_Plural()
        {
            Assert.AreEqual("Triangles", new English().GetShapeName(ShapeTypes.Triangle, 2));
        }

        [TestCase]
        public void Return_Circle_String_In_English_And_In_Singular()
        {
            Assert.AreEqual("Circle", new English().GetShapeName(ShapeTypes.Circle, 1));
        }

        [TestCase]
        public void Return_Circle_String_In_English_And_In_Plural()
        {
            Assert.AreEqual("Circles", new English().GetShapeName(ShapeTypes.Circle, 2));
        }

        [TestCase]
        public void Return_Rectangle_String_In_English_And_In_Singular()
        {
            Assert.AreEqual("Rectangle", new English().GetShapeName(ShapeTypes.Rectangle, 1));
        }

        [TestCase]
        public void Return_Rectangle_String_In_English_And_In_Plural()
        {
            Assert.AreEqual("Rectangles", new English().GetShapeName(ShapeTypes.Rectangle, 2));
        }

        [TestCase]
        public void Return_Trapeze_String_In_English_And_In_Singular()
        {
            Assert.AreEqual("Trapeze", new English().GetShapeName(ShapeTypes.Trapeze, 1));
        }

        [TestCase]
        public void Return_Trapeze_String_In_English_And_In_Plural()
        {
            Assert.AreEqual("Trapezes", new English().GetShapeName(ShapeTypes.Trapeze, 2));
        }
    }
}
