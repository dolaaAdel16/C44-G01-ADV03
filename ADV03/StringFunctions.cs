using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    internal class StringFunctions
    {
        public static int UpperCaseCount(string s)
        {
            if (string.IsNullOrEmpty(s)) { return 0; }
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static int LowerCaseCount(string s)
        {
            if (string.IsNullOrEmpty(s)) { return 0; }
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLower(s[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

