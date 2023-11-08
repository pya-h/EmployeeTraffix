using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using System.Text.RegularExpressions;

namespace EmployeeTraffix
{
    public partial class frmMain : Form
    {
        private const string PASSWORD = "whatever";
        private Dictionary<int, string> employees;
 
        public frmMain()
        {
            InitializeComponent();
        }

        private void loadTodayTraffix()
        {
            try
            {
                if (employees == null)
                    employees = new Dictionary<int, string>();
                employees.Clear();
                gridEmployees.Rows.Clear();
                DataTable dt = SQLiteInterface.Database.FetchEmployees();
                foreach (DataRow row in dt.Rows)
                {
                    string name = row[SQLiteInterface.TRAFFIX_COLUMNS_EN[0]].ToString();
                    int id = int.Parse(row["id"].ToString());
                    int rowIndex = gridEmployees.Rows.Add();
                    gridEmployees.Rows[rowIndex].Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[0]].Value = id;
                    DataRow traffic = SQLiteInterface.Database.DeclareTraffic(id, name, PersianDateTime.Today);
                    if(traffic != null)
                    {
                        for(byte i = 1; i <= 3; i++)
                            gridEmployees.Rows[rowIndex].Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[i]].Value
                                = traffic[SQLiteInterface.TRAFFIX_COLUMNS_EN[i]].ToString();

                    }
                    employees.Add(id, name);
                }
                gridEmployees.EndEdit();
                dt.Clear();
                gridEmployees.ClearSelection();

            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.loadTodayTraffix();
        }

        private void mnuAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (Microsoft.VisualBasic.Interaction.InputBox("رمز عبور را وارد کنید:", "رمزعبور") == PASSWORD)
                {
                    string name = TraffixTools.RemoveWhiteSpaces(
                        Microsoft.VisualBasic.Interaction.InputBox("نام پرسنل را وارد کنید:", "افزودن نام")
                    );
                    if (name.Length > 0)
                    {
                        SQLiteInterface.Database.AddEmployee(name);
                        loadTodayTraffix();
                    }
                }
                else
                    MessageBoxFarsi.Show("شما اجازه ی دسترسی به این بخش را ندارد!", "رمزعبور اشتباه",
                        MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);

            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                
            }
        }

        private void setTrafficTime(object sender, byte trafficType = 1)
        {
            try
            {
                Button btn = (Button)sender;
                int id = int.Parse(gridEmployees.CurrentRow.Cells[0].Value.ToString());
                string time = DateTime.Now.ToString("HH:mm");
                SQLiteInterface.Database.UpdateTraffic(id, this.employees[id], time, 
                    PersianDateTime.Today, trafficType);
                gridEmployees.Rows[gridEmployees.CurrentRow.Index]
                    .Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[trafficType]].Value = time;
                gridEmployees.RefreshEdit();
                btn.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
        }
        private void btnSetEntranceTime_Click(object sender, EventArgs e)
        {
            setTrafficTime(sender);           
        }

        private void btnSetExitTime_Click(object sender, EventArgs e)
        {
            setTrafficTime(sender, 2);
        }

        private void setAbsenceTypeButtons_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnAbsenceType = (Button)sender;
                int id = int.Parse(gridEmployees.CurrentRow.Cells[0].Value.ToString());
                SQLiteInterface.Database.UpdateTraffic(id, this.employees[id], btnAbsenceType.Text, 
                    PersianDateTime.Today, 3);
                gridEmployees.Rows[gridEmployees.CurrentRow.Index]
                    .Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[3]].Value = btnAbsenceType.Text;
                gridEmployees.RefreshEdit();
            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
        }

        private void gridEmployees_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                btnSetEntranceTime.Enabled = gridEmployees.CurrentRow
                    .Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[1]].Value == null ||
                        gridEmployees.CurrentRow.Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[1]].Value.ToString().Length == 0;
                btnSetExitTime.Enabled = gridEmployees.CurrentRow
                    .Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[2]].Value == null ||
                        gridEmployees.CurrentRow.Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[2]].Value.ToString().Length == 0;
            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            this.Text = PersianDateTime.Now.ToLongDateString() + " " + DateTime.Now.ToString("HH:mm:ss") +
                "                                                                                              ورود و خروج رسمی";
        }

        private void mnuReports_Click(object sender, EventArgs e)
        {
            try
            {
                if (Microsoft.VisualBasic.Interaction.InputBox("رمز عبور را وارد کنید:", "رمزعبور") == PASSWORD)
                    (new frmReports()).Show();
                else
                    MessageBoxFarsi.Show("شما اجازه ی دسترسی به این بخش را ندارد!", "رمزعبور اشتباه",
                        MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
        }

        private void mnuModifyEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                if (Microsoft.VisualBasic.Interaction.InputBox("رمز عبور را وارد کنید:", "رمزعبور") == PASSWORD)
                {

                }
                else
                    MessageBoxFarsi.Show("شما اجازه ی دسترسی به این بخش را ندارد!", "رمزعبور اشتباه",
                        MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
        }

        private void btnHourlyBreak_Click(object sender, EventArgs e)
        {
            try
            {
                string start = Microsoft.VisualBasic.Interaction.InputBox("ساعت شروع مرخصی", "ساعت شروع مرخصی"),
                    end = Microsoft.VisualBasic.Interaction.InputBox("ساعت پایان مرخصی", "ساعت پایان مرخصی");
                if(start.Length > 0 && end.Length > 0)
                {
                    Regex clockFormatRegex = new Regex(@"[0-2][0-9]:[0-5][0-9]");
                    if (!clockFormatRegex.IsMatch(start) || !clockFormatRegex.IsMatch(end))
                        throw new FormatException("ساعت ها باید به فرمت HH:MM باشند.");
                    // and some other checks
                    string text = gridEmployees.Rows[gridEmployees.CurrentRow.Index]
                        .Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[3]].Value != null ? gridEmployees.Rows[gridEmployees.CurrentRow.Index]
                        .Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[3]].Value.ToString() : "";
                    if (text.Length > 0)
                        text += " - ";
                    text += "از " + start + " الی " + end + " ساعتی";
                    int id = int.Parse(gridEmployees.CurrentRow.Cells[0].Value.ToString());
                    SQLiteInterface.Database.UpdateTraffic(id, this.employees[id], text,
                        PersianDateTime.Today, 3);
                    gridEmployees.Rows[gridEmployees.CurrentRow.Index]
                        .Cells[SQLiteInterface.TRAFFIX_COLUMNS_EN[3]].Value = text;
                    gridEmployees.RefreshEdit();
                }
                else
                {
                    MessageBoxFarsi.Show("ساعت شروع یا پایان مرخصی معتبر نیست!", "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);                    
                }
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
        }
    }
}
