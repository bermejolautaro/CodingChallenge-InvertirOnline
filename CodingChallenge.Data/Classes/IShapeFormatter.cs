namespace CodingChallenge.Data.Classes
{
    public interface IShapeFormatter
    {
        string FormatSummary(ShapesCalculator calculator, ILanguage language);
    }
}