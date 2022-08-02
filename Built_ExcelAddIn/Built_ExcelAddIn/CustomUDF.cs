using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_ExcelAddIn
{
    public static class CustomUDF
    {
        [ExcelFunction(Description = "Reverse string function")]
        public static string ReverseString(string str)
        {
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
