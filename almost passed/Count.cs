using System;
using System.Collections.Generic;
using System.Text;

namespace almost_passed
{
    class Count
    {
        public static int GetLen(string s)
        {
            var length = 0;
            foreach (var VARIABLE in s)
            {
                length += System.Text.Encoding.GetEncoding("utf-8").GetByteCount(Convert.ToString(VARIABLE)) > 1 ? 2 : 1;
            }

            return length;
        }
    }
}
