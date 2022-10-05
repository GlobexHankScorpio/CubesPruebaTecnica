namespace CubesIntersection.Base;

public abstract class CubicObject
{
    public abstract bool IsColliding(CubicObject cObject);

    public abstract bool IsIntersected(CubicObject cObject);
}