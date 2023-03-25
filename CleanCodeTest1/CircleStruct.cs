namespace CleanCodeTest1;

internal struct CircleStruct : IShape
{
    public readonly float radius;
    
    public CircleStruct(in float radius)
    {
        this.radius = radius;
    }

    #region IShape Methods
    
    public float Area()
    {
        return (float)Math.PI*radius*radius;
    }
    
    #endregion
}