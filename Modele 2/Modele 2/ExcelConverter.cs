using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Modele_2
{
    internal class ExcelConverter
    {
        public static void SaveGridToExcel(DataGridView grid, string fileName, string sheetName)
        {
            Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.SheetsInNewWorkbook = 1;
            Excel.Workbook workBook = excelApp.Workbooks.Add(Type.Missing);
            excelApp.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)excelApp.Worksheets.get_Item(1);
            sheet.Name = sheetName;

            int offsetRow = 1;

            for (int j = 0; j < grid.ColumnCount; j++)
            {
                sheet.Cells[offsetRow, j + 1] = grid.Columns[j].HeaderText;
            }

            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.ColumnCount; j++)
                    sheet.Cells[offsetRow + i + 1, j + 1] = grid[j, i].Value;
            }

            excelApp.Application.ActiveWorkbook.SaveAs($"{fileName}.xlsx");
            workBook.Close(true);
            excelApp.Quit();
        }
    }
}
