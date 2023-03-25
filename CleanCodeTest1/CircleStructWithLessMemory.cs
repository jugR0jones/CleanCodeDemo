namespace CleanCodeTest1;

internal struct CircleStructWithLessMemory : IShape
{
    private readonly float area;
    
    public CircleStructWithLessMemory(in float radius)
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