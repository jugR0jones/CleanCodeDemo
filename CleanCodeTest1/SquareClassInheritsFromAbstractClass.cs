namespace CleanCodeTest1;

internal class SquareClassInheritsFromAbstractClass : ShapeAbstractClass
{
    public readonly float lengthOfSide;

    public SquareClassInheritsFromAbstractClass(in float lengthOfSide) : base()
    {
        this.lengthOfSide = lengthOfSide;
    }

    #region ShapeAbstractClass Methods
    
    public override float Area()
    {
        return lengthOfSide * lengthOfSide;
    }
    
    #endregion
}