namespace CleanCodeTest1;

public class CircleClassInheritsFromInterfaceWithPreComputation : IShape
{
    public readonly float radius;

    private readonly float area;
    
    public CircleClassInheritsFromInterfaceWithPreComputation(in float radius)
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