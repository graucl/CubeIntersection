using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.Domain.Entities.ValueObjects
{
    public sealed class Point3D
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }


        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
