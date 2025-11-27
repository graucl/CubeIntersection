using CubeIntersection.Distributed.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.Application.Services.Contracts
{
    public interface IIntersectionApplicationService
    {
        IntersectionResultDto Intersect(IntersectRequest request);
    }
}
