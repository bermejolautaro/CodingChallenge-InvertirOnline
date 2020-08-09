using System.Collections.Generic;

namespace CodingChallenge.Data.Classes
{
    public interface ILanguage
    {
        string GetEmptyMessage();
        string GetHeader();
        string GetFooterTitle();
        string GetFooterContent(IEnumerable<ShapeResult> results);
        string GetShapeName(ShapeTypes shapeType, int amountOfShapes);
        IEnumerable<string> GetLines(IDictionary<ShapeTypes, ShapeResult> calculator);
    }
}