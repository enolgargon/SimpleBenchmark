using System.Diagnostics;
using SingleTesting;

namespace BenchmarkTable
{
    public abstract class AbstractBenchmarkTable : IBenchmarkTable
    {
        public void Test(BenchmarkTest test)
        {
            var timer = Stopwatch.StartNew();
            timer.Start();
            Execute(test);
            timer.Stop();
            test.Duration = timer.ElapsedMilliseconds;
        }

        protected abstract void Execute(BenchmarkTest test);
    }
}