using System;
using Abstraction.Interfaces;

namespace Abstraction
{
    abstract class Figure : ISurfaceCalculatable, IPerimeterCalculatable
    {
        abstract public double CalcPerimeter();

        abstract public double CalcSurface();
    }
}
