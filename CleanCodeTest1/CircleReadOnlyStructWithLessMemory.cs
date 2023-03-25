namespace CleanCodeTest1;

public readonly struct CircleReadOnlyStructWithLessMemory : IShape
{
    private readonly float area;
    
    public CircleReadOnlyStructWithLessMemory(in float radius)
    {
        area = (float)Math.PI*radius*radius;
    }

    #region IShape Methods
    
    public float Area()
    {
        return area;
    }
    
    #endregion
}