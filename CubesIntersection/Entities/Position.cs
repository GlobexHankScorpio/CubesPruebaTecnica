namespace CubesIntersection.Entities;

public class Position
{
    public double x { get; }
    public double y { get; }
    public double z { get; }

    public Position(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
}
