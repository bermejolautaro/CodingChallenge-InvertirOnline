using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ShapesCalculator
    {
        private readonly IEnumerable<IShape> _shapes = Enumerable.Empty<IShape>();
        private readonly IDictionary<ShapeTypes, ShapeResult> _resultsPerShape = new Dictionary<ShapeTypes, ShapeResult>();


        public ShapesCalculator(IEnumerable<IShape> shapes)
        {
            _shapes = shapes;

            CalculateShapesResults();
        }

        private void CalculateShapesResults()
        {
            foreach (var shape in _shapes)
            {
                if(!_resultsPerShape.ContainsKey(shape.GetShapeType()))
                {
                    _resultsPerShape.Add(shape.GetShapeType(), new ShapeResult());
                }

                _resultsPerShape[shape.GetShapeType()].Perimeter += shape.CalculatePerimeter();
                _resultsPerShape[shape.GetShapeType()].Area += shape.CalculateArea();
                _resultsPerShape[shape.GetShapeType()].Amount++;
            }
        }

        public IDictionary<ShapeTypes, ShapeResult> GetResultsPerShape() =>
            _resultsPerShape.ToDictionary(x => x.Key, y => y.Value);

        public IEnumerable<ShapeResult> GetResults() =>
            _resultsPerShape.Values;


        public bool IsEmpty() => 
            !_shapes.Any();
    }
}
