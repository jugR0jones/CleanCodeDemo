namespace CleanCodeTest1;

internal class Triangle : ShapeAbstractClass
{
    public readonly float length;
    public readonly float height;
    
    public Triangle(in float length, in float height)
    {
        this.length = length;
        this.height=height;
    }

    #region IShape Methods
    
    public override float Area()
    {
        return 0.5f*length*height;
    }
    
    #endregion
}