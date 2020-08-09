using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Languages
{
    public class English : Language
    {
        public override string GetEmptyMessage() =>"Empty list of shapes!";

        public override string GetHeader() =>"Shapes report";

        public override string GetFooterTitle() =>"TOTAL:";

        protected override string GetTranslatedArea() => "Area";

        protected override string GetTranslatedPerimeter() => "Perimeter";

        protected override string GetTranslatedShapesInPlural() => "Shapes";
        protected override string GetTranslatedShapesInSingular() => "Shape";

        protected override string GetSquareInSingular() => "Square";
        protected override string GetSquareInPlural() => "Squares";

        protected override string GetTriangleInSingular() => "Triangle";
        protected override string GetTriangleInPlural() => "Triangles";

        protected override string GetCircleInSingular() => "Circle";
        protected override string GetCircleInPlural() => "Circles";

        protected override string GetRectangleInSingular() => "Rectangle";
        protected override string GetRectangleInPlural() => "Rectangles";

        protected override string GetTrapezeInSingular() => "Trapeze";
        protected override string GetTrapezeInPlural() => "Trapezes";
    }
}
