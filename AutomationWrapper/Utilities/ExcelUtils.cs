using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationWrapper.Utilities
{
    public class ExcelUtils
    {
        public static object[] GetSheetIntoObjectArray(string file,string sheetName)
        {
            IXLWorkbook book = new XLWorkbook(file);

            IXLWorksheet sheet = book.Worksheet(sheetName);

            IXLRange range = sheet.RangeUsed();

            int rowCount = range.RowCount();
            int colCount = range.ColumnCount();

            object[] main = new object[rowCount - 1];

            for (int r = 2; r <= rowCount; r++)
            {
                object[] temp = new object[colCount];
                for (int c = 1; c <= colCount; c++)
                {
                    object value = Convert.ToString(range.Cell(r, c).Value);
                    temp[c - 1] = value;
                }
                main[r - 2] = temp;
            }

            book.Dispose();

            return main;
        }
    }
}
