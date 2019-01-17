using BenchmarkingLibrary;
using BenchmarkTable;
using SingleTesting;
using Util;

namespace Testing
{
    public class BasicTest : AbstractTest
    {
        public BasicTest()
        {
            Results.Add("Add", new BenchmarkTest(() =>
            {
                for (var i = -50; i < 50; i++)
                for (var j = -50; j < 50; j++)
                    Methods.Add(i, j);
            }));

            Results.Add("Sub", new BenchmarkTest(() =>
            {
                for (var i = -50; i < 50; i++)
                for (var j = -50; j < 50; j++)
                    Methods.Sub(i, j);
            }));

            Results.Add("Mul", new BenchmarkTest(() =>
            {
                for (var i = -50; i < 50; i++)
                for (var j = -50; j < 50; j++)
                    Methods.Mul(i, j);
            }));
        }

        public override void Execute()
        {
            IBenchmarkTable benchmarkTable = Configuration.BenchmarkTableFactory.CreateTable();
            foreach (var test in Results.Values)
                benchmarkTable.Test(test);
        }
    }
}