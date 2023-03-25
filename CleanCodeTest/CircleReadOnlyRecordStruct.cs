namespace CleanCodeTest1;

internal readonly record struct CircleReadOnlyRecordStruct : IShape
{
    public readonly float radius;
    
    public CircleReadOnlyRecordStruct(in float radius)
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