namespace CleanCodeTest1;

internal readonly record struct CircleReadOnlyRecordStructWithPreComputation : IShape
{
    public readonly float radius;

    private readonly float area;
    
    public CircleReadOnlyRecordStructWithPreComputation(in float radius)
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