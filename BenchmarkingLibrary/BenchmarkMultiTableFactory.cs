using BenchmarkTable;

namespace BenchmarkTableFactory
{
    public class BenchmarkMultiTableFactory : IBenchmarkTableFactory
    {
        public IBenchmarkTable CreateTable()
        {
            return new MultiThreadBenchmarkTable();
        }
    }
}