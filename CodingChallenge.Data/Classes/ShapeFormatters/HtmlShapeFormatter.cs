using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.ShapeFormatters
{
    public class HtmlShapeFormatter : IShapeFormatter
    {
        public string FormatSummary(ShapesCalculator calculator, ILanguage language)
        {
            StringBuilder sb = new StringBuilder();

            if (calculator.IsEmpty()) 
                return $"<h1>{language.GetEmptyMessage()}</h1>";

            sb.Append($"<h1>{language.GetHeader()}</h1>");
            sb.Append(string.Join("", language.GetLines(calculator.GetResultsPerShape()).Select(line => $"{line} <br/>")));
            sb.Append($"{language.GetFooterTitle()}<br/>");
            sb.Append(language.GetFooterContent(calculator.GetResults()));

            return sb.ToString();
        }
    }
}
