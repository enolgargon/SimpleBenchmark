using System.Runtime.InteropServices;

namespace SimpleBenchmarkConsole
{
    public class Methods
    {
        [DllImport("BenchmarkingMethods.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int a, int b);

        [DllImport("BenchmarkingMethods.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Sub(int a, int b);

        [DllImport("BenchmarkingMethods.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Mul(int a, int b);
    }
}