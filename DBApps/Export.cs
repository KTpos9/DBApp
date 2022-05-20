using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBApps
{
    public class Export
    {
        //public static void ExportToExcel(DataGridView dataGridView)
        //{
        //    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
        //    xcelApp.Application.Workbooks.Add(Type.Missing);

        //    for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
        //    {
        //        xcelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
        //    }

        //    for (int i = 0; i < dataGridView.Rows.Count-1; i++)
        //    {
        //        for (int j = 0; j < dataGridView.Columns.Count; j++)
        //        {
        //            xcelApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }
            
        //    xcelApp.Columns.AutoFit();
        //    xcelApp.Visible = true;
        //}
        public static void ExportToExcel(DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "report";
            for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = ".xlsx";
            saveFileDialoge.Filter = "Excel Workbook |*.xlsx" ;   //"Excel Workbook (*.xlsx|*.xlsx)"
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
