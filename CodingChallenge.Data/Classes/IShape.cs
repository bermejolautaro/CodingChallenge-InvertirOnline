﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public interface IShape
    {
        decimal CalculatePerimeter();
        decimal CalculateArea();
        ShapeTypes GetShapeType();
    }
}
