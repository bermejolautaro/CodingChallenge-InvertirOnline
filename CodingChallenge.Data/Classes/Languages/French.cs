using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Languages
{
    public class French : Language
    {
        public override string GetEmptyMessage() => "Liste vide de formes!";

        public override string GetHeader() => "Rapport de formulaires";

        public override string GetFooterTitle() =>  "TOTAL:";

        protected override string GetTranslatedArea() => "Superficie";

        protected override string GetTranslatedPerimeter() => "Périmètre";

        protected override string GetTranslatedShapesInSingular() => "Forme";
        protected override string GetTranslatedShapesInPlural() => "Formes";

        protected override string GetSquareInSingular() => "Carré";
        protected override string GetSquareInPlural() => "Carrés";

        protected override string GetTriangleInSingular() => "Triangle";
        protected override string GetTriangleInPlural() => "Triangles";

        protected override string GetCircleInSingular() => "Cercle";
        protected override string GetCircleInPlural() => "Cercles";

        protected override string GetRectangleInSingular() => "Rectangle";
        protected override string GetRectangleInPlural() => "Rectangles";

        protected override string GetTrapezeInSingular() => "Trapèze";
        protected override string GetTrapezeInPlural() => "Trapèzes";
    }
}
