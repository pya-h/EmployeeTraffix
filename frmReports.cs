using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;

namespace EmployeeTraffix
{
    public partial class frmReports : Form
    {
        private DataTable data;
        private const string EXCEL_PASSWORD = "110.011";
        public frmReports()
        {
            InitializeComponent();
        }

        public DataTable Data
        {
            get { return this.data; }
            set
            {
                this.data = value;
                gridTraffix.DataSource = this.data;
            }
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            this.reloadTraffix();
        }

        private void gridTraffix_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                // translate column headers
                DataTable dt = (DataTable)gridTraffix.DataSource;
                dt.Columns[0].ColumnName = SQLiteInterface.TRAFFIX_COLUMNS_FA[4];
                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    dt.Columns[i + 1].ColumnName = SQLiteInterface.TRAFFIX_COLUMNS_FA[i];
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);

            }
        }
        private void datePickers_SelectedDateChanged(DateTime selectedDateTime, PersianDateTime selectedPersianDateTime)
        {
            this.reloadTraffix();
        }

        private void reloadTraffix()
        {
            try
            {
                DataTable dt = SQLiteInterface.Database.FetchTraffix(dtpFrom.GetSelectedDateInPersianDateTime(),
                    dtpUntil.GetSelectedDateInPersianDateTime());
                //dt.DefaultView.Sort = "id asc";
                this.Data = dt;
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                
            }
        }
        public static void SmoothUpdateProgressBar(ToolStripProgressBar progressBar, int value)
        {
            if (value < 100)    // prevent ArgumentException error on value = 100
            {
                progressBar.Value = value + 1;    // set the value +1
            }

            progressBar.Value = value;    // set the actual value

        }

        private void tsBtnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog outputFile = new SaveFileDialog();
                outputFile.Filter = "Excel File (*.xlsx)| *.xlsx";

                if (outputFile.ShowDialog() != DialogResult.OK || outputFile.FileName.Trim() == "")
                {
                    MessageBoxFarsi.Show("برای ذخیره سازی فایل اکسل باید محل ذخیره سازی مشخص شود!", "مسیر اشتباه",
                        MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                    return;
                }
                tsBtnExportExcel.Visible = false;
                pgbExporting.Visible = true;
                pgbExporting.Value = 0;
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                app.DefaultSheetDirection = 1; // right to left
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                // see the excel sheet behind the program  
                app.Visible = false;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "لیست ورود و خروج رسمی";
                //worksheet.Cells.WrapText = true;

                // storing header part in Excel  
                for (int i = 1; i < gridTraffix.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = gridTraffix.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                int x = gridTraffix.Rows.Count;
                for (int i = 0; i < gridTraffix.Rows.Count; i++)
                {
                    for (int j = 0; j < gridTraffix.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = gridTraffix.Rows[i].Cells[j].Value.ToString();
                    }

                    SmoothUpdateProgressBar(pgbExporting, (int)(100 * (i + 1) / gridTraffix.Rows.Count));
                }
                SmoothUpdateProgressBar(pgbExporting, 99);
                worksheet.Columns.AutoFit();
                worksheet.Cells.WrapText = true;
                worksheet.Cells.Style.Locked = true;
                worksheet.Protect(EXCEL_PASSWORD);

                //worksheet.Cells.Style.Font.Size = 15;

                // worksheet.Cells.get_Range("A1", "E1").Style.Color = Color.Green;
                // save the application
                workbook.SaveAs(outputFile.FileName, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing
                );
                // Exit from the application  

                tsBtnExportExcel.Visible = true;
                pgbExporting.Visible = false;
                app.Quit();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBoxFarsi.Show("یک خطای نامشخص اتفاق افتاده است:\n" + ex.Message, "خطای نامشخص",
                    MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);

            }
        }
    }
}
