using System.Diagnostics;

namespace CleanCodeTest1;

internal static class TestRunner
{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="tests"></param>
    public static void Run(in bool warmup,
        in int numberOfIterationsPerTest,
        in Dictionary<string, IShape> tests)
    {
        Dictionary<string, IShape>.KeyCollection keyCollection = tests.Keys;

        List<Tuple<string, float>> results = new List<Tuple<string, float>>(keyCollection.Count);
        
        Stopwatch stopwatch = new Stopwatch();
        
        foreach (string key in keyCollection)
        {
            IShape shape = tests[key];

            float accumulatedArea = 0.0f;
            if (warmup)
            {
                for (int i = 0; i < 10; i++)
                {
                    accumulatedArea += shape.Area();
                }
            }
            
            stopwatch.Restart();
            accumulatedArea = 0.0f;
            for (int i = numberOfIterationsPerTest; i >= 0; i--)
            {
                accumulatedArea += shape.Area();
            }
            stopwatch.Stop();
            
            results.Add(new Tuple<string, float>(key, stopwatch.ElapsedTicks));
        }
        
        results.Sort(delegate(Tuple<string, float> tuple, Tuple<string, float> tuple1)
        {
            if (tuple.Item2 < tuple1.Item2)
            {
                return -1;
            } 
            
            if (tuple.Item2 > tuple1.Item2)
            {
                return 1;
            }

            return 0;
        });

        for (int i = 0; i < results.Count; i++)
        {
            Console.WriteLine(results[i].Item1 + ": " + results[i].Item2 + "  " + (float)results[i].Item2 / numberOfIterationsPerTest + " ticks / shape");   
        }
    }
}