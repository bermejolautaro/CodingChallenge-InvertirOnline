using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Languages
{
    public class Spanish : Language
    {
        public override string GetEmptyMessage() => "Lista vacía de formas!";

        public override string GetHeader() => "Reporte de Formas";

        public override string GetFooterTitle() => "TOTAL:";

        protected override string GetTranslatedPerimeter() => "Perímetro";

        protected override string GetTranslatedArea() => "Área";

        protected override string GetTranslatedShapesInPlural() => "Formas";
        protected override string GetTranslatedShapesInSingular() => "Forma";

        protected override string GetSquareInSingular() => "Cuadrado";
        protected override string GetSquareInPlural() => "Cuadrados";

        protected override string GetTriangleInSingular() => "Triángulo";
        protected override string GetTriangleInPlural() => "Triángulos";

        protected override string GetCircleInSingular() => "Círculo";
        protected override string GetCircleInPlural() => "Círculos";

        protected override string GetRectangleInSingular() => "Rectángulo";
        protected override string GetRectangleInPlural() => "Rectángulos";

        protected override string GetTrapezeInSingular() => "Trapecio";
        protected override string GetTrapezeInPlural() => "Trapecios";
    }
}
