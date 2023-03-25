namespace CleanCodeTest1;

internal readonly struct CircleReadOnlyStructWithPreComputation : IShape
{
    public readonly float radius;

    private readonly float area;
    
    public CircleReadOnlyStructWithPreComputation(in float radius)
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