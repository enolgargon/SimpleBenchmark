namespace SimpleBenchmarkConsole
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var test = new BasicTest();

            test.Execute();
            test.PrintResults();
        }
    }
}