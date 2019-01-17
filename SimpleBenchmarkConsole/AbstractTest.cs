using System;
using System.Collections.Generic;
using BenchmarkingLibrary;

namespace SimpleBenchmarkConsole
{
    public abstract class AbstractTest : ITest
    {
        protected AbstractTest()
        {
            Results = new Dictionary<string, BenchmarkTest>();
        }

        protected IDictionary<string, BenchmarkTest> Results { get; }

        public abstract void Execute();

        public void PrintResults()
        {
            Console.WriteLine("Results");
            foreach (var key in Results.Keys)
            {
                Console.WriteLine($"\t{key}:");
                Console.WriteLine(
                    $"\t\tTotal time {Results[key].Duration}\tAverage time: {Results[key].AverageDuration}");
            }
        }
    }
}