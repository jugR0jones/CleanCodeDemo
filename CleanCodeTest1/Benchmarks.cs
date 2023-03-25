using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace CleanCodeTest1;

[SimpleJob(RuntimeMoniker.Net60)]
public class Benchmarks
{
    private static readonly CircleClassInheritsFromAbstractClass circleClassInheritsFromAbstractClass = new CircleClassInheritsFromAbstractClass(1.0f);
    private static readonly CircleClassInheritsFromAbstractClassWithLessMemory circleClassInheritsFromAbstractClassWithLessMemory = new CircleClassInheritsFromAbstractClassWithLessMemory(1.0f);
    private static readonly CircleClassInheritsFromAbstractClassWithPreComputation circleClassInheritsFromAbstractClassWithPreComputation = new CircleClassInheritsFromAbstractClassWithPreComputation(1.0f);
    private static readonly CircleClassInheritsFromInterface circleClassInheritsFromInterface = new CircleClassInheritsFromInterface(1.0f);
    private static readonly CircleClassInheritsFromInterfaceWithLessMemory circleClassInheritsFromInterfaceWithLessMemory = new CircleClassInheritsFromInterfaceWithLessMemory(1.0f);
    private static readonly CircleClassInheritsFromInterfaceWithPreComputation circleClassInheritsFromInterfaceWithPreComputation = new CircleClassInheritsFromInterfaceWithPreComputation(1.0f);

    private static readonly CircleReadOnlyStruct circleReadOnlyStruct = new CircleReadOnlyStruct(1.0f);
    
    //
    
    [Benchmark]
    public float TestCircleClassInheritsFromAbstractClass()
    {
        return circleClassInheritsFromAbstractClass.Area();
    }
    
    [Benchmark]
    public float TestCircleClassInheritsFromAbstractClassWithLessMemory()
    {
        return circleClassInheritsFromAbstractClassWithLessMemory.Area();
    }
    
    [Benchmark]
    public float TestCircleClassInheritsFromAbstractClassWithPreComputation()
    {
        return circleClassInheritsFromAbstractClassWithPreComputation.Area();
    }
   
    //
    
    [Benchmark]
    public float TestCircleClassInheritsFromInterface()
    {
        return circleClassInheritsFromInterface.Area();
    }
    
    [Benchmark]
    public float TestCircleClassInheritsFromInterfaceWithLessMemory()
    {
        return circleClassInheritsFromInterfaceWithLessMemory.Area();
    }
    
    [Benchmark]
    public float TestCircleClassInheritsFromInterfaceWithPreComputation()
    {
        return circleClassInheritsFromInterfaceWithPreComputation.Area();
    }
    
    //
    
    [Benchmark]
    public float TestCircleReadOnlyStruct()
    {
        return circleReadOnlyStruct.Area();
    }
}