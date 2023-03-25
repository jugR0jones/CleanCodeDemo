namespace CleanCodeTest1;

public class CircleClassInheritsFromInterface : IShape
{
    public readonly float radius;
    
    public CircleClassInheritsFromInterface(in float radius)
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