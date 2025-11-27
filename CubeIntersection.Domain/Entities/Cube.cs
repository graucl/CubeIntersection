using CubeIntersection.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.Domain.Entities.Entities
{
    public sealed class Cube
    {
        public Point3D Center { get; }
        public double Side { get; }

        public Cube(Point3D center, double side)
        {
            if (side <= 0) throw new ArgumentException("Side must be > 0", nameof(side));
            Center = center ?? throw new ArgumentNullException(nameof(center));
            Side = side;
        }

        public (double min, double max) RangeX() => (Center.X - Side / 2, Center.X + Side / 2);
        public (double min, double max) RangeY() => (Center.Y - Side / 2, Center.Y + Side / 2);
        public (double min, double max) RangeZ() => (Center.Z - Side / 2, Center.Z + Side / 2);
    }
}
