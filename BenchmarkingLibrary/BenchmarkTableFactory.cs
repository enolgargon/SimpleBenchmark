namespace BenchmarkingLibrary
{
    public class BenchmarkTableFactory
    {
        public static IBenchmarkTable CreateSingleThreadTable()
        {
            return new SingleThreadBenchmarkTable();
        }

        public static IBenchmarkTable CreateMultiThreadTable()
        {
            return new MultiThreadBenchmarkTable();
        }
    }
}