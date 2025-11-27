using CubeIntersection.Application.Services.Contracts;
using CubeIntersection.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.Application.Services.Implementations
{
    public class CubeIntersectionService : ICubeIntersectionService
    {
        public double IntersectionVolume(Cube a, Cube b)
        {
            var ox = OverlapLength(a.RangeX(), b.RangeX());
            var oy = OverlapLength(a.RangeY(), b.RangeY());
            var oz = OverlapLength(a.RangeZ(), b.RangeZ());

            return ox * oy * oz;
        }

        public bool Intersects(Cube a, Cube b)
        {
            var ox = OverlapLength(a.RangeX(), b.RangeX());
            var oy = OverlapLength(a.RangeY(), b.RangeY());
            var oz = OverlapLength(a.RangeZ(), b.RangeZ());

            return ox > 0 && oy > 0 && oz > 0;
        }

        private static double OverlapLength((double min, double max) r1, (double min, double max) r2)
        {
            var overlap = Math.Min(r1.max, r2.max) - Math.Max(r1.min, r2.min);
            return Math.Max(0.0, overlap);
        }
    }
}
