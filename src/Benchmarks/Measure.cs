using System;
using System.Diagnostics;

namespace Benchmarks
{
    public sealed class Measure : IDisposable
    {
        private readonly Stopwatch time;
        private readonly string?   name;

        private Measure(string? name = null)
        {
            this.name = name;
            time      = new Stopwatch();
            time.Start();
        }

        public static Measure Execution(string? name = null)
        {
            return new(name);
        }

        public void Dispose()
        {
            time.Stop();
            long duration = time.ElapsedTicks;

            if(!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"{name}: {duration} 100ns");
            }
        }
    }
}
