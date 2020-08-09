﻿using CodingChallenge.Data.Classes;
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
    public class SpanishShould
    {
        [TestCase]
        public void Return_Square_String_In_Spanish_And_In_Singular()
        {
            Assert.AreEqual("Cuadrado", new Spanish().GetShapeName(ShapeTypes.Square, 1));
        }

        [TestCase]
        public void Return_Squares_String_In_Spanish_And_In_Plural()
        {
            Assert.AreEqual("Cuadrados", new Spanish().GetShapeName(ShapeTypes.Square, 2));
        }

        [TestCase]
        public void Return_Triangle_String_In_Spanish_And_In_Singular()
        {
            Assert.AreEqual("Triángulo", new Spanish().GetShapeName(ShapeTypes.Triangle, 1));
        }

        [TestCase]
        public void Return_Triangle_String_In_Spanish_And_In_Plural()
        {
            Assert.AreEqual("Triángulos", new Spanish().GetShapeName(ShapeTypes.Triangle, 2));
        }

        [TestCase]
        public void Return_Circle_String_In_Spanish_And_In_Singular()
        {
            Assert.AreEqual("Círculo", new Spanish().GetShapeName(ShapeTypes.Circle, 1));
        }

        [TestCase]
        public void Return_Circle_String_In_Spanish_And_In_Plural()
        {
            Assert.AreEqual("Círculos", new Spanish().GetShapeName(ShapeTypes.Circle, 2));
        }

        [TestCase]
        public void Return_Rectangle_String_In_Spanish_And_In_Singular()
        {
            Assert.AreEqual("Rectángulo", new Spanish().GetShapeName(ShapeTypes.Rectangle, 1));
        }

        [TestCase]
        public void Return_Rectangle_String_In_Spanish_And_In_Plural()
        {
            Assert.AreEqual("Rectángulos", new Spanish().GetShapeName(ShapeTypes.Rectangle, 2));
        }

        [TestCase]
        public void Return_Trapeze_String_In_Spanish_And_In_Singular()
        {
            Assert.AreEqual("Trapecio", new Spanish().GetShapeName(ShapeTypes.Trapeze, 1));
        }

        [TestCase]
        public void Return_Trapeze_String_In_Spanish_And_In_Plural()
        {
            Assert.AreEqual("Trapecios", new Spanish().GetShapeName(ShapeTypes.Trapeze, 2));
        }
    }
}
