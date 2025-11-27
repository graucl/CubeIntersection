using CubeIntersection.Application.Services.Contracts;
using CubeIntersection.Distributed.Dtos;
using CubeIntersection.Domain.Entities.Entities;
using CubeIntersection.Domain.Entities.ValueObjects;

namespace CubeIntersection.Application.Services.Implementations
{
    public class IntersectionApplicationService : IIntersectionApplicationService
    {
        private readonly IIntersectionCalculator _calculator;

        public IntersectionApplicationService(IIntersectionCalculator calculator)
        {
            _calculator = calculator;
        }

        public IntersectionResultDto Intersect(IntersectRequest request)
        {
            var cubeA = new Cube(new Point3D(request.A.CenterX, request.A.CenterY, request.A.CenterZ), request.A.Side);
            var cubeB = new Cube(new Point3D(request.B.CenterX, request.B.CenterY, request.B.CenterZ), request.B.Side);


            var (intersects, volume) = _calculator.Calculate(cubeA, cubeB);


            return new IntersectionResultDto { Intersects = intersects, IntersectedVolume = volume };
        }
    }
}
