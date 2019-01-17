using System;

namespace SingleTesting
{
    public class BenchmarkTest
    {
        /// <summary>
        /// Number of times by default to execute the function
        /// </summary>
        private const int DefaultNTimes = 50;

        public BenchmarkTest(Action function, int nTimes = DefaultNTimes)
        {
            Function = function;
            NTimes = nTimes;
        }

        /// <summary>
        /// FUnction which it will be executed
        /// </summary>
        public Action Function { get; }

        /// <summary>
        /// Number of times to execute the function
        /// </summary>
        public int NTimes { get; }

        /// <summary>
        /// Total duration of the execution in milliseconds
        /// </summary>
        public long Duration { get; internal set; }

        /// <summary>
        /// Average duration of each execution in milliseconds
        /// </summary>
        public long AverageDuration => Duration / NTimes;
    }
}