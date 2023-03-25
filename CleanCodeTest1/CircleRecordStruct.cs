namespace CleanCodeTest1;

internal record struct CircleRecordStruct : IShape
{
    public readonly float radius;
    
    public CircleRecordStruct(in float radius)
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