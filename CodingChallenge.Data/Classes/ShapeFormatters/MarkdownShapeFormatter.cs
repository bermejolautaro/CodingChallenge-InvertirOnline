using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.ShapeFormatters
{
    public class MarkdownShapeFormatter : IShapeFormatter
    {
        public string FormatSummary(ShapesCalculator calculator, ILanguage language)
        {
            StringBuilder sb = new StringBuilder();

            if (calculator.IsEmpty())
                return $"# {language.GetEmptyMessage()}\n";

            sb.Append($"# {language.GetHeader()}\n");
            sb.Append(string.Join("", language.GetLines(calculator.GetResultsPerShape()).Select(line => $"{line}\n")));
            sb.Append($"{language.GetFooterTitle()}\n");
            sb.Append(language.GetFooterContent(calculator.GetResults()));

            return sb.ToString();
        }
    }
}
