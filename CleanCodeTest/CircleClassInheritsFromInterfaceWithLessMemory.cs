namespace CleanCodeTest1;

internal class CircleClassInheritsFromInterfaceWithLessMemory : IShape
{
    private readonly float area;

    public CircleClassInheritsFromInterfaceWithLessMemory(in float radius)
    {
        area = (float) Math.PI * radius * radius;
    }

    #region IShape Methods
    
    public float Area()
    {
        return area;
    }
    
    #endregion    
}