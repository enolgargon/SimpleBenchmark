using System.Threading.Tasks;

namespace BenchmarkingLibrary
{
    public class MultiThreadBenchmarkTable : AbstractBenchmarkTable
    {
        protected override void Execute(BenchmarkTest test)
        {
            Parallel.For(0, test.NTimes, i => test.Function.Invoke());
        }
    }
}