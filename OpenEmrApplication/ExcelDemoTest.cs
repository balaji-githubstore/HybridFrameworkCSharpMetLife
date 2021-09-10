using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ClosedXML.Excel;

namespace MetLife.OpenEmrApplication
{
    class ExcelDemoTest
    {
        [Test]
        public void ExcelReadTest()
        {
            IXLWorkbook book = new XLWorkbook(@"D:\B-Mine\Company\Company\MetLife\OpenEmrApplication\OpenEmrApplication\TestData\OpenEMRData.xlsx");

            IXLWorksheet sheet=  book.Worksheet("ValidCredentialTest");

            IXLRange range =sheet.RangeUsed();

            int rowCount = range.RowCount();
            int colCount = range.ColumnCount();

            object[] main = new object[rowCount-1]; //rowcount-1

            for(int r=2;r<=rowCount; r++)
            {
                object[] temp = new object[4]; //colcount
                for(int c=1;c<=colCount;c++)
                {
                    string value = Convert.ToString(range.Cell(r, c).Value);
                    Console.WriteLine(value);
                    temp[c-1] = value;
                }
                main[r-2] = temp;
            }

            Console.WriteLine(main);
          

            book.Dispose();

        }
    }
}
