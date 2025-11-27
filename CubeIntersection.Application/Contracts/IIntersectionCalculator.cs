using CubeIntersection.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.Application.Services.Contracts
{
    public interface IIntersectionCalculator
    {
        (bool intersects, double volume) Calculate(Cube a, Cube b);
    }
}
