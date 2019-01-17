using BenchmarkTable;

namespace BenchmarkTableFactory
{
    public interface IBenchmarkTableFactory
    {
        IBenchmarkTable CreateTable();
    }
}