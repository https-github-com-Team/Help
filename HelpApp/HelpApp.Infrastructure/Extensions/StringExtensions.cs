using System;
using System.Collections.Generic;
using System.Text;

namespace HelpApp.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string Test(this string str,string val)
        {
            return str + val;
        }
    }
}
