using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Socona.LeetCode.Q28
{
    public class Test : TestBase
    {
        public override long Run()
        {
            Solution sol = new Solution();
            Dictionary<string, string> tests = new Dictionary<string, string>();
            tests["bcaabaabcaabaabaacaabcbaabc"] = "aabaacaabc";
            List<int> results = new List<int>();
            stopwatch.Start();
            foreach (var kv in tests)
            {
                var result =  sol.StrStr(kv.Key, kv.Value);
                results.Add(result);
            }
            stopwatch.Stop();
            foreach(var r in results)
            {
                Console.WriteLine(r);
            }
            return stopwatch.ElapsedMilliseconds;
        }
    }
}