using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeMo.Extensions
{
    public static class StringExtensions
    {
        public static byte[] ToBytesFromBase64String(this string str)
        {
            return Convert.FromBase64String(str);
        }
    }
}
