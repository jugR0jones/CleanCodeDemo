using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace CleanCodeTest1;

internal static class Program
{
    private static void Main()
    {
        
       //     Summary[] summary = BenchmarkRunner.Run(typeof(Program).Assembly);
         
       var summary = BenchmarkRunner.Run<Benchmarks>();
            // var summary = BenchmarkRunner.Run(typeof(MyBenchmarkClass));
            // var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            //
        // const float smallRadius = 1.0f;
        //
        // const int numberOfIterations = 10_000_000;
        //
        // Dictionary<string, IShape> circleShapes = new Dictionary<string, IShape>()
        // {
        //     {"CircleClassInheritsFromAbstractClass",                    new CircleClassInheritsFromAbstractClass(smallRadius) },
        //     {"CircleClassInheritsFromAbstractClassWithPreComputation",  new CircleClassInheritsFromAbstractClassWithPreComputation(smallRadius) },
        //     {"CircleClassInheritsFromAbstractClassWithLessMemory",      new CircleClassInheritsFromAbstractClassWithLessMemory(smallRadius) },
        //     
        //     {"CircleClassInheritsFromInterface",                        new CircleClassInheritsFromInterface(smallRadius) },
        //     {"CircleClassInheritsFromInterfaceWithPreComputation",      new CircleClassInheritsFromInterfaceWithPreComputation(smallRadius) },
        //     {"CircleClassInheritsFromInterfaceWithLessMemory",          new CircleClassInheritsFromInterfaceWithLessMemory(smallRadius) },
        //     
        //     {"CircleStruct",                                            new CircleStruct(smallRadius) },
        //     {"CircleStructWithPreComputation",                          new CircleStructWithPreComputation(smallRadius) },
        //     {"CircleStructWithLessMemory",                              new CircleStructWithLessMemory(smallRadius) },
        //     
        //     {"CircleReadOnlyStruct",                                    new CircleReadOnlyStruct(smallRadius) },
        //     {"CircleReadOnlyStructWithPreComputation",                  new CircleReadOnlyStructWithPreComputation(smallRadius) },
        //     {"CircleReadOnlyStructWithLessMemory",                      new CircleReadOnlyStructWithLessMemory(smallRadius) },
        //     
        //     {"CircleRecordStruct",                                      new CircleRecordStruct(smallRadius)},
        //     {"CircleRecordStructWithPreComputation",                    new CircleRecordStructWithPreComputation(smallRadius)},
        //     {"CircleRecordStructWithLessMemory",                        new CircleRecordStructWithLessMemory(smallRadius)},
        //     
        //     {"CircleReadOnlyRecordStruct",                              new CircleReadOnlyRecordStruct(smallRadius)},
        //     {"CircleReadOnlyRecordStructWithPreComputation",            new CircleReadOnlyRecordStructWithPreComputation(smallRadius)},
        //     {"CircleReadOnlyRecordStructWithLessMemory",                new CircleReadOnlyRecordStructWithLessMemory(smallRadius)}
        // };
        //
        //
        // TestRunner.Run(true, numberOfIterations, circleShapes);
        //
        // //
        // // Stopwatch stopwatch = new Stopwatch();
        // //
        // // List<IShape> shapesList = new List<IShape>()
        // // {
        // //     new SquareClassInheritsFromAbstractClass(1.0f),
        // // //    new SquareStruct(1.0f),
        // //     new CircleClassInheritsFromAbstractClass(1.0f),
        // //     new Triangle(1.0f, 1.0f),
        // //     new CircleWithPreComputation(1.0f),
        // //     new TriangleWithPreComputation(1.0f, 1.0f),
        // //     new CircleWithLessMemory(1.0f),
        // //     new SquareClassInheritsFromAbstractClass(10.0f),
        // //     new CircleClassInheritsFromAbstractClass(10.0f),
        // //     new SquareClassInheritsFromAbstractClass(100.0f),
        // //     new CircleClassInheritsFromAbstractClass(100.0f),
        // //     new SquareClassInheritsFromAbstractClass(2.0f),
        // //     new CircleClassInheritsFromAbstractClass(2.0f),
        // //     new SquareClassInheritsFromAbstractClass(4.0f),
        // //     new CircleClassInheritsFromAbstractClass(4.0f),
        // //     new SquareClassInheritsFromAbstractClass(512.0f),
        // //     new CircleClassInheritsFromAbstractClass(512.0f),
        // // };
        // // IShape[] shapesArray = shapesList.ToArray();
        // //
        // // ///////////////////////////////////////////////////////////
        // //
        // // Console.WriteLine("Repeat Count: 1");
        // // stopwatch.Restart();
        // // float area = TotalAreaVTBL(shapesList.Count, shapesList);
        // // stopwatch.Stop();
        // // Console.WriteLine("TotalAreaVTBL: " + stopwatch.ElapsedTicks + "  " +  (float)stopwatch.ElapsedTicks / numberOfIterations + " ticks / shape");
        // //
        // // Console.WriteLine("Repeat Count: " + numberOfIterations);
        // // stopwatch.Restart();
        // // for (int i = 0; i < numberOfIterations; i++)
        // // {
        // //     area = TotalAreaVTBL(shapesList.Count, shapesList);
        // // }
        // // stopwatch.Stop();
        // // Console.WriteLine("TotalAreaVTBL: " + stopwatch.ElapsedTicks + "  " +  (float)stopwatch.ElapsedTicks / numberOfIterations + " ticks / shape");
        // //
        // // ///////////////////////////////////////////////////////////
        // //
        // // Console.WriteLine("Repeat Count: 1");
        // // stopwatch.Restart();
        // // area = TotalAreaVTBL(shapesArray.Length, shapesArray);
        // // stopwatch.Stop();
        // // Console.WriteLine("TotalAreaVTBL: " + stopwatch.ElapsedTicks + "  " +  (float)stopwatch.ElapsedTicks / numberOfIterations + " ticks / shape");
        // //
        // // Console.WriteLine("Repeat Count: " + numberOfIterations);
        // // stopwatch.Restart();
        // // for (int i = 0; i < numberOfIterations; i++)
        // // {
        // //     area = TotalAreaVTBL(shapesArray.Length, shapesArray);
        // // }
        // // stopwatch.Stop();
        // // Console.WriteLine("TotalAreaVTBL: " + stopwatch.ElapsedTicks + "  " +  (float)stopwatch.ElapsedTicks / numberOfIterations + " ticks / shape");
        // //
        // // ///////////////////////////////////////////////////////////
        // //
        // // Console.WriteLine("Repeat Count: 1");
        // // stopwatch.Restart();
        // // area = TotalAreaVTBL2(in shapesArray);
        // // stopwatch.Stop();
        // // Console.WriteLine("TotalAreaVTBL2: " + stopwatch.ElapsedTicks + "  " + (float)stopwatch.ElapsedTicks / numberOfIterations  + " ticks / shape");
        // //
        // // Console.WriteLine("Repeat Count: " + numberOfIterations);
        // // stopwatch.Restart();
        // // for (int i = 0; i < numberOfIterations; i++)
        // // {
        // //     area = TotalAreaVTBL2(in shapesArray);
        // // }
        // // stopwatch.Stop();
        // // Console.WriteLine("TotalAreaVTBL2: " + stopwatch.ElapsedTicks + "  " + (float)stopwatch.ElapsedTicks / numberOfIterations + " ticks / shape");
    }
    
    private static float TotalAreaVTBL(in int shapeCount, in List<IShape> shapes)
    {
        float accum = 0.0f;
        for(int i = 0; i < shapeCount; ++i)
        {
            accum += shapes[i].Area();
        }
    
        return accum;
    }
    
    private static float TotalAreaVTBL(in int shapeCount, in IShape[] shapes)
    {
        float accum = 0.0f;
        for(int i = 0; i < shapeCount; ++i)
        {
            accum += shapes[i].Area();
        }
    
        return accum;
    }
    
    private static float TotalAreaVTBL2(in IShape[] shapes)
    {
        float accum = 0.0f;
        for(int i=shapes.Length-1; i>=0; i--)
        {
            accum += shapes[i].Area();
        }
    
        return accum;
    }
}



internal readonly struct SquareStruct : IShape
{
    private readonly float lengthOfSide;
    
    public SquareStruct(in float lengthOfSideInit)
    {
        lengthOfSide = lengthOfSideInit;
    }

    public float Area()
    {
        return lengthOfSide * lengthOfSide;
    }
}





class rectangle : ShapeAbstractClass
{
    public rectangle(float WidthInit, float HeightInit)
    {
        Width = WidthInit;
        Height = HeightInit;
    }

    public override float Area() {return Width*Height;}
    
    private float Width;
    private float Height;
};

