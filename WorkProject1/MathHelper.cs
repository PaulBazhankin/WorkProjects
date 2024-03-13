using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProject1
{
    static public class MathHelper
    {
        static public decimal Sum(params decimal[] values)
        {
            decimal result = 0;
            foreach(decimal value in values)
            {
                result += value;
            }
            return result;
        }
    }
}
