namespace CleanCodeTest1;

internal struct CircleStructWithPreComputation : IShape
{
    public readonly float radius;

    private readonly float area;
    
    public CircleStructWithPreComputation(in float radius)
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