namespace CleanCodeTest1;

public record struct CircleRecordStructWithLessMemory : IShape
{
    private readonly float area;
    
    public CircleRecordStructWithLessMemory(in float radius)
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