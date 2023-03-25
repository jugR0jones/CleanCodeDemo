namespace CleanCodeTest1;

public readonly struct CircleReadOnlyStruct : IShape
{
    public readonly float radius;
    
    public CircleReadOnlyStruct(in float radius)
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