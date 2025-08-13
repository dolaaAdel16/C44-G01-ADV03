using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    internal class ConditonFunc
    {
        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static bool NamesLen(string name)
        {
            return name.Length > 4;

        }
        public static bool NamesLenEqual3(string name)
        {
            return name.Length == 3;

        }

    }
}

