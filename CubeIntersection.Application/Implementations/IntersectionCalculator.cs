using CubeIntersection.Application.Services.Contracts;
using CubeIntersection.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.Application.Services.Implementations
{
    public class IntersectionCalculator : IIntersectionCalculator
    {
        public (bool intersects, double volume) Calculate(Cube a, Cube b)
        {
            if (a == null) throw new ArgumentNullException(nameof(a));
            if (b == null) throw new ArgumentNullException(nameof(b));

            var volume = IntersectionVolume(a, b);
            var intersects = volume > 0.0;
            return (intersects, volume);
        }

        public double IntersectionVolume(Cube a, Cube b)
        {
            var ox = OverlapLength(a.RangeX(), b.RangeX());
            var oy = OverlapLength(a.RangeY(), b.RangeY());
            var oz = OverlapLength(a.RangeZ(), b.RangeZ());

            return ox * oy * oz;
        }

        private static double OverlapLength((double min, double max) r1, (double min, double max) r2)
        {
            var overlap = Math.Min(r1.max, r2.max) - Math.Max(r1.min, r2.min);
            return Math.Max(0.0, overlap);
        }
    }
}
