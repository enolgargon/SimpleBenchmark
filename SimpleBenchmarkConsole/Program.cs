using System;
using BenchmarkingLibrary;
using BenchmarkTableFactory;
using CommandLine;
using Testing;

namespace SimpleBenchmarkConsole
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var parser = new Parser(config => config.HelpWriter = Console.Out);
            var options = parser.ParseArguments<Options>(args).Value;

            ITest test = null;
            if (options.BasicTest)
                test = new BasicTest();

            if (options.MultiThread)
                Configuration.BenchmarkTableFactory = new BenchmarkMultiTableFactory();

            if (test == null)
                Console.WriteLine("You must specify one type of test at least");
            else
            {
                test.Execute();
                test.PrintResults();
            }
        }
    }
}