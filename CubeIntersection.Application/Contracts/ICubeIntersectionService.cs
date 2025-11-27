using CubeIntersection.Domain.Entities.Entities;

namespace CubeIntersection.Application.Services.Contracts
{
    public interface ICubeIntersectionService
    {
        bool Intersects(Cube a, Cube b);
        double IntersectionVolume(Cube a, Cube b);
    }
}
