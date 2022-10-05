using CubesIntersection.Base;

namespace CubesIntersection.Entities;

public class Cube : CubicObject
{
    private Size depth { get; set; }
    private Size width { get; set; }
    private Size height { get; set; }

    private Cube(Position position, double end)
    {
        depth = new Size(position.z, end);
        width = new Size(position.x, end);
        height = new Size(position.y, end);
    }

    public static Cube MyCube(Position centerPosition, double end)
    {
        return new Cube(centerPosition, end);
    }

    public override bool IsColliding(CubicObject cube)
    {
        //Calculate mathematically accross _depth, _width and _height fields
        return true;
    }

    public override bool IsIntersected(CubicObject cube)
    {
        //Calculate mathematically accross _depth, _width and _height fields
        return true;
    }
}