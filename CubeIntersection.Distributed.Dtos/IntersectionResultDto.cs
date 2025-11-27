using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.Distributed.Dtos
{
    public class IntersectionResultDto
    {
        public bool Intersects { get; set; }
        public double IntersectedVolume { get; set; }
    }
}
