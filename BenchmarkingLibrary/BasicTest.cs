using BenchmarkingLibrary;
using BenchmarkTable;
using SingleTesting;
using Util;

namespace Testing
{
    public class BasicTest : AbstractTest
    {
        public BasicTest(int numberOfTimes)
        {
            Results.Add("Add", new BenchmarkTest(() =>
            {
                for (var i = -1000; i < 1000; i++)
                for (var j = -1000; j < 1000; j++)
                    Methods.Add(i, j);
            }, numberOfTimes));

            Results.Add("Sub", new BenchmarkTest(() =>
            {
                for (var i = -1000; i < 1000; i++)
                for (var j = -1000; j < 1000; j++)
                    Methods.Sub(i, j);
            }, numberOfTimes));

            Results.Add("Mul", new BenchmarkTest(() =>
            {
                for (var i = -1000; i < 1000; i++)
                for (var j = -1000; j < 1000; j++)
                    Methods.Mul(i, j);
            }, numberOfTimes));
        }

        public override void Execute()
        {
            IBenchmarkTable benchmarkTable = Configuration.BenchmarkTableFactory.CreateTable();
            foreach (var test in Results.Values)
                benchmarkTable.Test(test);
        }
    }
}