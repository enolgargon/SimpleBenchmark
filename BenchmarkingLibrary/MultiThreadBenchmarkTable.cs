using System.Threading.Tasks;
using SingleTesting;

namespace BenchmarkTable
{
    public class MultiThreadBenchmarkTable : AbstractBenchmarkTable
    {
        protected override void Execute(BenchmarkTest test)
        {
            Parallel.For(0, test.NTimes, i => test.Function.Invoke());
        }
    }
}