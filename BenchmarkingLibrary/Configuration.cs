using BenchmarkTableFactory;

namespace BenchmarkingLibrary
{
    public static class Configuration
    {
        public static IBenchmarkTableFactory BenchmarkTableFactory = new BenchmarkSingleTableFactory();
    }
}