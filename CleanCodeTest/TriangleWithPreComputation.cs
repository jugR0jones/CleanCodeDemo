namespace CleanCodeTest1;

internal class TriangleWithPreComputation : IShape
{
    public readonly float length;
    public readonly float height;
    
    private readonly float area;

    public TriangleWithPreComputation(in float length, in float height)
    {
        this.length = length;
        this.height = height;

        area = 0.5f * length * height;
    }

    #region IShape Methods
    
    public float Area()
    {
        return area;
    }
    
    #endregion
}