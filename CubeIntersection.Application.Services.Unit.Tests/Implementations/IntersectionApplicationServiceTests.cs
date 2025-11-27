using CubeIntersection.Domain.Entities.Entities;
using CubeIntersection.Domain.Entities.ValueObjects;
using Xunit;

namespace CubeIntersection.Application.Services.Implementations.Unit.Tests
{
    public class IntersectionApplicationServiceTests
    {
        [Fact]
        public void Calculate_CubesSeparated_NoIntersection_NoVolume()
        {
            var calc = new IntersectionCalculator();
            var a = new Cube(new Point3D(0, 0, 0), 1);
            var b = new Cube(new Point3D(5, 5, 5), 1);

            var (intersects, volume) = calc.Calculate(a, b);

            Assert.False(intersects);
            Assert.Equal(0, volume);
        }

        [Fact]
        public void Calculate_CubesTouchOnFace_NoIntersection_NoVolume()
        {
            var calc = new IntersectionCalculator();
            var a = new Cube(new Point3D(0, 0, 0), 2);
            var b = new Cube(new Point3D(2, 0, 0), 2);

            var (intersects, volume) = calc.Calculate(a, b);

            Assert.False(intersects);
            Assert.Equal(0, volume);
        }

        [Fact]
        public void Calculate_IntersectTrue_CorrectVolume()
        {
            var calc = new IntersectionCalculator();
            var a = new Cube(new Point3D(0, 0, 0), 2);
            var b = new Cube(new Point3D(0.5, 0, 0), 2);

            var (intersects, volume) = calc.Calculate(a, b);

            Assert.True(intersects);
            Assert.Equal(1.5 * 2 * 2, volume);
        }
    }
}