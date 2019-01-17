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
    }
}