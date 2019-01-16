using System.Diagnostics;

namespace BenchmarkingLibrary
{
    public abstract class AbstractBenchmarkTable : IBenchmarkTable
    {
        public void Test(ref BenchmarkTest test)
        {
            var timer = Stopwatch.StartNew();
            timer.Start();
            execute(test);
            timer.Stop();
            test.Duration = timer.ElapsedMilliseconds;
        }

        protected abstract void execute(BenchmarkTest test);
    }
}