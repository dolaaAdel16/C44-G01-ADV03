using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    internal class StringConditions
    {
        public static bool CompareGtr(int a, int b)
        {
            return a < b;
        }
        public static bool CompareSmaller(int a, int b)
        {
            return a > b;
        }

        public static bool CompareStringGtr(string a, string b)
        {
            return a.Length > b.Length;
        }
        public static bool CompareStringSmall(string a, string b)
        {
            return a.Length < b.Length;
        }

    }
}

