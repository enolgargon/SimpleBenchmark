namespace SimpleBenchmarkConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var test = new BasicTest();
            test.Execute();
            test.PrintResults();
        }
    }
}