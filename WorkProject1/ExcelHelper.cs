using System;

namespace WorkProject1
{
    static public class ExcelHelper
    {
        static public int ColumnNumber(string column)//Номер столбца (1,2,...) из обозначения (A,B,...,AA,AB,...,BA,...)
        {
            int result = 0;
            for(int i = 0; i < column.Length; i++)
            {
                result += (int)Math.Pow(26, i) * (column[column.Length-i-1] - 'A' + 1);
            }
            return result;
        }
        static public string ColumnLabel(int column)//Обозначение столбца (A, B,..., AA, AB,..., BA,...) из номера (1,2,...) 
        {
            string result = "";
            do
            {
                result = result.Insert(0,((char)('A' + column % 26 - 1)).ToString());
                column /= 26;
            } while (column > 0);
            return result;
        }
    }
}
