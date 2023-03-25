namespace CleanCodeTest1;

public record struct CircleRecordStructWithPreComputation : IShape
{
    public readonly float radius;

    private readonly float area;
    
    public CircleRecordStructWithPreComputation(in float radius)
    {
        this.radius = radius;
        area = (float)Math.PI*radius*radius;
    }

    #region IShape Methods
    
    public float Area()
    {
        return area;
    }
    
    #endregion
}