namespace CleanCodeTest1;

public class CircleClassInheritsFromAbstractClassWithLessMemory : ShapeAbstractClass
{
    private readonly float area;

    public CircleClassInheritsFromAbstractClassWithLessMemory(in float radius)
    {
        area = (float) Math.PI * radius * radius;
    }

    #region IShape Methods
    
    public override float Area()
    {
        return area;
    }
    
    #endregion
}