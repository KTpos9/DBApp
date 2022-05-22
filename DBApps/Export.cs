using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
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
        public static void ExportToPDF(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {
                    if (File.Exists(save.FileName))

                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)

                        {
                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }

                    }

                    if (!ErrorMessage)
                    {
                        try

                        {
                            PdfPTable pTable = new PdfPTable(dataGridView.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);
                            }

                            foreach (DataGridViewRow viewRow in dataGridView.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(dcell.Value.ToString());

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }
                            MessageBox.Show("Data Export Successfully", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }

                    }

                }

            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
    }
}

