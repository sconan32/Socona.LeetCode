using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socona.LeetCode
{
    public abstract class TestBase
    {
        protected Stopwatch stopwatch;

        public TestBase()
        {
            stopwatch = new Stopwatch();
        }

        public abstract long Run();

        public virtual void Evaluate()
        {
            Console.WriteLine($"Start Evaluating...");
            var milliseconds = Run();
            Console.WriteLine($"Complete.{Environment.NewLine}Times Elapsed:{milliseconds} ms");
        }

    }
}
