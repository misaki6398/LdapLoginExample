using LdapLoginExample.Model;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LdapLoginExample.Utilitys
{
    public static class ExcelUtility
    {
        private static readonly int CellLengthLimit = 32767;
        private static readonly int HeaderCellMinLength = 10;
        public static IWorkbook DictionaryToWorkBook<T>(Dictionary<string, List<T>> dictionarys)
        {
            if (dictionarys is null)
            {
                return null;
            }
            IWorkbook wb = new XSSFWorkbook();
            ICellStyle headStyle = GetHeadStyle(wb);
            ICellStyle colStyle = GetColStyle(wb);
            foreach (var dictionary in dictionarys)
            {
                ISheet ws;
                if (dictionary.Key != string.Empty)
                {
                    ws = wb.CreateSheet(dictionary.Key);
                }
                else
                {
                    ws = wb.CreateSheet("Sheet1");
                }

                ws.CreateRow(0);
                ws.CreateFreezePane(0, 1);

                var firstRow = dictionary.Value[0].GetType().GetProperties();
                int[] maxColLength = Enumerable.Repeat(HeaderCellMinLength, firstRow.Count()).ToArray();
                int headCellCount = 0;
                foreach (var property in firstRow)
                {
                    ICell cell = ws.GetRow(0).CreateCell(headCellCount);
                    cell.SetCellValue(property.Name);
                    cell.CellStyle = headStyle;
                    headCellCount++;
                }

                for (int i = 0; i < dictionary.Value.Count(); i++)
                {
                    var model = dictionary.Value[i];
                    ws.CreateRow(i + 1);
                    int j = 0;
                    foreach (var prop in model.GetType().GetProperties())
                    {                        
                        string cellString = (string)prop.GetValue(model, null);
                        if (cellString.Length > CellLengthLimit)
                        {
                            cellString = cellString.Substring(0, CellLengthLimit);
                        }
                        if (maxColLength[j] < cellString.Length)
                        {
                            maxColLength[j] = cellString.Length;
                        }
                        ICell cell = ws.GetRow(i + 1).CreateCell(j);
                        cell.SetCellValue(cellString);
                        cell.CellStyle = colStyle;
                        j++;
                    }

                }

                ws.SetAutoFilter(new CellRangeAddress(0, dictionary.Value.Count(), 0, firstRow.Count() - 1));
                                
                for (int i = 0; i < firstRow.Count(); i++)
                {
                    maxColLength[i] = (maxColLength[i] > 100) ? 100 : maxColLength[i];
                    ws.SetColumnWidth(i, maxColLength[i] * 400);
                }
            }

            return wb;
        }

        private static ICellStyle GetHeadStyle(IWorkbook workbook)
        {
            ICellStyle headStyle = workbook.CreateCellStyle();
            IFont headFont = workbook.CreateFont();
            headFont.IsBold = true;
            headStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey25Percent.Index;
            headStyle.FillPattern = NPOI.SS.UserModel.FillPattern.SolidForeground;
            headStyle.BorderLeft = BorderStyle.Medium;
            headStyle.BorderTop = BorderStyle.Medium;
            headStyle.BorderRight = BorderStyle.Medium;
            headStyle.BorderBottom = BorderStyle.Medium;
            headStyle.SetFont(headFont);

            return headStyle;
        }

        private static ICellStyle GetColStyle(IWorkbook workbook)
        {
            ICellStyle colStyle = workbook.CreateCellStyle();
            colStyle.BorderLeft = BorderStyle.Thin;
            colStyle.BorderTop = BorderStyle.Thin;
            colStyle.BorderRight = BorderStyle.Thin;
            colStyle.BorderBottom = BorderStyle.Thin;
            IFont colFont = workbook.CreateFont();
            colFont.FontName = "Calibri";
            colStyle.SetFont(colFont);
            return colStyle;
        }

    }
}
