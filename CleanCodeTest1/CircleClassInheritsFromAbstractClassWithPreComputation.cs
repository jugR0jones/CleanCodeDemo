namespace CleanCodeTest1;

internal class CircleClassInheritsFromAbstractClassWithPreComputation : ShapeAbstractClass
{
    public readonly float radius;

    private readonly float area;

    public CircleClassInheritsFromAbstractClassWithPreComputation(in float radius)
    {
        this.radius = radius;
        area = (float) Math.PI * radius * radius;
    }

    #region IShape Methods
    
    public override float Area()
    {
        return area;
    }
    
    #endregion
}