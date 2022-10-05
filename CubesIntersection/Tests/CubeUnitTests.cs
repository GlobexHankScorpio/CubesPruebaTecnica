using CubesIntersection.Entities;

namespace CubesIntersection.Tests;
public class CubeUnitTests
{
    [Fact]
    public void Collides()
    {
        Cube firstCube = Cube.MyCube(new Position(1, 2, 3), 2);

        Cube secondCube = Cube.MyCube(new Position(1, 2, 3), 2);

        Assert.True(firstCube.IsColliding(secondCube));
    }

    [Fact]
    public void Intersects()
    {
        Cube firstCube = Cube.MyCube(new Position(4, 4, 4), 1);

        Cube secondCube = Cube.MyCube(new Position(4, 4, 4), 2);

        Assert.True(firstCube.IsIntersected(secondCube));
    }
}