using CommandLine;

namespace SimpleBenchmarkConsole
{
    public class Options
    {
        [Option('b', "basic",
            HelpText =
                "Use this option to execute a basic test which test the computer with simple arithmetic operation",
            Required = false)]
        public bool BasicTest { get; set; }

        [Option('m', "multi-thread",
            HelpText =
                "Use this option to execute the test in multi-thread mode",
            Required = false)]
        public bool MultiThread { get; set; }

        [Option('n', "number-of-times", HelpText = "Number of times to execute each test", Required = false,
            DefaultValue = 1000)]
        public int NumberOfTimes { get; set; }
    }
}