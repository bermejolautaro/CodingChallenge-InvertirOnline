using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Language : ILanguage
    {
        public string GetFooterContent(IEnumerable<ShapeResult> results)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GetAmountOfShapesLine(results));
            sb.Append(GetSumPerimetersLine(results));
            sb.Append(GetSumAreasLine(results));
            return sb.ToString();
        }

        public IEnumerable<string> GetLines(IDictionary<ShapeTypes, ShapeResult> resultsPerShape)
        {
            var lines = new List<string>();

            foreach (var shapeType in resultsPerShape.Keys)
            {
                lines.Add($"{resultsPerShape[shapeType].Amount} {GetShapeName(shapeType, resultsPerShape[shapeType].Amount)} " +
                          $"| {GetTranslatedArea()} {resultsPerShape[shapeType].Area:#.##} " +
                          $"| {GetTranslatedPerimeter()} {resultsPerShape[shapeType].Perimeter:#.##}");
            }

            return lines;
        }

        public string GetShapeName(ShapeTypes shapeType, int amountOfShapes) => 
            amountOfShapes > 1 
            ? GetShapeNameInPlural(shapeType) 
            : GetShapeName(shapeType);

        private string GetAmountOfShapesLine(IEnumerable<ShapeResult> results) => 
            $"{results.Sum(r => r.Amount)} {(GetTranslatedShape(results))} ";

        private string GetTranslatedShape(IEnumerable<ShapeResult> results) => 
            results.Sum(r => r.Amount) > 1 
            ? GetTranslatedShapesInPlural().ToLower() 
            : GetTranslatedShapesInSingular().ToLower();

        private string GetSumAreasLine(IEnumerable<ShapeResult> results) => 
            $"{GetTranslatedArea()} {(results.Sum(r => r.Area).ToString("#.##"))}";

        private string GetSumPerimetersLine(IEnumerable<ShapeResult> results) => 
            $"{GetTranslatedPerimeter()} {results.Sum(r => r.Perimeter).ToString("#.##")} ";

        private string GetShapeName(ShapeTypes shapeType)
        {
            switch (shapeType)
            {
                case ShapeTypes.Square:
                    return GetSquareInSingular();
                case ShapeTypes.Triangle:
                    return GetTriangleInSingular();
                case ShapeTypes.Circle:
                    return GetCircleInSingular();
                case ShapeTypes.Rectangle:
                    return GetRectangleInSingular();
                case ShapeTypes.Trapeze:
                    return GetTrapezeInSingular();
                default: throw new ArgumentException($"Unknown shape type: {nameof(shapeType)}");
            }
        }

        private string GetShapeNameInPlural(ShapeTypes shapeType)
        {
            switch (shapeType)
            {
                case ShapeTypes.Square:
                    return GetSquareInPlural();
                case ShapeTypes.Triangle:
                    return GetTriangleInPlural();
                case ShapeTypes.Circle:
                    return GetCircleInPlural();
                case ShapeTypes.Rectangle:
                    return GetRectangleInPlural();
                case ShapeTypes.Trapeze:
                    return GetTrapezeInPlural();
                default: throw new ArgumentException($"Unknown shape type: {nameof(shapeType)}");
            }
        }

        public abstract string GetEmptyMessage();

        public abstract string GetHeader();

        public abstract string GetFooterTitle();

        protected abstract string GetTranslatedPerimeter();

        protected abstract string GetTranslatedArea();

        protected abstract string GetTranslatedShapesInSingular();
        protected abstract string GetTranslatedShapesInPlural();

        protected abstract string GetSquareInSingular();
        protected abstract string GetSquareInPlural();

        protected abstract string GetTrapezeInSingular();
        protected abstract string GetTrapezeInPlural();

        protected abstract string GetRectangleInSingular();
        protected abstract string GetRectangleInPlural();

        protected abstract string GetCircleInSingular();
        protected abstract string GetCircleInPlural();

        protected abstract string GetTriangleInSingular();
        protected abstract string GetTriangleInPlural();
    }
}
