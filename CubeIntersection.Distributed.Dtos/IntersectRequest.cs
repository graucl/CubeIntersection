using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.Distributed.Dtos
{
    public sealed class IntersectRequest
    {
        public CubeDto A { get; set; }
        public CubeDto B { get; set; }
    }
}
