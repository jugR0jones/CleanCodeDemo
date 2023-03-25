namespace CleanCodeTest1;

internal readonly record struct CircleReadOnlyRecordStructWithLessMemory : IShape
{
    private readonly float area;
    
    public CircleReadOnlyRecordStructWithLessMemory(in float radius)
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