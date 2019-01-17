using BenchmarkTable;

namespace BenchmarkTableFactory
{
    public class BenchmarkSingleTableFactory : IBenchmarkTableFactory
    {
        public IBenchmarkTable CreateTable()
        {
            return new SingleThreadBenchmarkTable();
        }
    }
}