using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProject1
{
    static public class ExcelHelper
    {
        static public int CollumnNumber(string collumn)
        {
            int result = 0;
            for(int i = 0; i < collumn.Length; i++)
            {
                result += (int)Math.Pow(26, i) * (collumn[collumn.Length-i-1] - 'A' + 1);
            }
            return result;
        }
        static public string CollumnLabel(int collumn)
        {
            string result = "";
            do
            {
                result = result.Insert(0,((char)('A' + collumn % 26 - 1)).ToString());
                collumn /= 26;
            } while (collumn > 0);
            return result;
        }
    }
}
