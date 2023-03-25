namespace CleanCodeTest1;

internal class CircleClassInheritsFromAbstractClass : ShapeAbstractClass
{
    public readonly float radius;
    
    public CircleClassInheritsFromAbstractClass(in float radius) : base()
    {
        this.radius = radius;
    }

    #region ShapeAbstractClass Methods
    
    public override float Area()
    {
        return (float)Math.PI*radius*radius;
    }
    
    #endregion
}