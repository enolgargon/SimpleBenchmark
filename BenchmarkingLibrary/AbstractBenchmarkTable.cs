using System.Diagnostics;

namespace BenchmarkingLibrary
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