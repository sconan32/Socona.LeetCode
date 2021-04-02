using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socona.LeetCode.Q28
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {              
                return 0;
            }
            Span<int> next = stackalloc int[needle.Length];
            GetNext(ref next, needle);
            int j = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                while (j > 0 && haystack[i] != needle[j])
                {
                    j = next[j - 1];
                }
                if (haystack[i] == needle[j])
                {
                    j++;
                }
                if (j == needle.Length)
                {
                    return i - j + 1;
                }

            }
            return -1;
        }

        private void GetNext(ref Span<int> next, string needle)
        {            
            next[0] = 0;
            int j = 0;
            for (int i = 1; i < needle.Length; i++)
            {
                while (j > 0 && needle[i] != needle[j])
                {
                    j = next[j - 1];
                }
                if (needle[i] == needle[j])
                {
                    j++;
                }
                next[i] = j;
            }
           
        }
    }
}
