using SingleTesting;

namespace BenchmarkTable
{
    public class SingleThreadBenchmarkTable : AbstractBenchmarkTable
    {
        protected override void Execute(BenchmarkTest test)
        {
            for (var i = 0; i < test.NTimes; i++)
                test.Function.Invoke();
        }
    }
}