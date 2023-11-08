namespace EmployeeTraffix
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridEmployees = new BehComponents.DataGridViewX(this.components);
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSetEntranceTime = new BehComponents.ButtonX();
            this.btnSetExitTime = new BehComponents.ButtonX();
            this.btnSetInLegalLeave = new BehComponents.ButtonX();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModifyEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetOnAMission = new BehComponents.ButtonX();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.btnHourlyBreak = new BehComponents.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEmployees
            // 
            this.gridEmployees.AllowUserToAddRows = false;
            this.gridEmployees.AllowUserToDeleteRows = false;
            this.gridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridEmployees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEmployees.ColumnHeadersHeight = 40;
            this.gridEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.entrace,
            this.exit,
            this.absenceType});
            this.gridEmployees.Columns_EnglishDate = ((System.Collections.Generic.List<string>)(resources.GetObject("gridEmployees.Columns_EnglishDate")));
            this.gridEmployees.Columns_PersianDate = ((System.Collections.Generic.List<string>)(resources.GetObject("gridEmployees.Columns_PersianDate")));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridEmployees.Location = new System.Drawing.Point(4, 70);
            this.gridEmployees.MultiSelect = false;
            this.gridEmployees.Name = "gridEmployees";
            this.gridEmployees.ReadOnly = true;
            this.gridEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEmployees.ShowEditingIcon = false;
            this.gridEmployees.Size = new System.Drawing.Size(589, 635);
            this.gridEmployees.TabIndex = 0;
            this.gridEmployees.SelectionChanged += new System.EventHandler(this.gridEmployees_SelectionChanged);
            // 
            // name
            // 
            this.name.FillWeight = 15F;
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // entrace
            // 
            this.entrace.FillWeight = 20F;
            this.entrace.HeaderText = "ورود";
            this.entrace.MaxInputLength = 5;
            this.entrace.Name = "entrace";
            this.entrace.ReadOnly = true;
            // 
            // exit
            // 
            this.exit.FillWeight = 20F;
            this.exit.HeaderText = "خروج";
            this.exit.MaxInputLength = 5;
            this.exit.Name = "exit";
            this.exit.ReadOnly = true;
            // 
            // absenceType
            // 
            this.absenceType.FillWeight = 60F;
            this.absenceType.HeaderText = "مرخصی";
            this.absenceType.Name = "absenceType";
            this.absenceType.ReadOnly = true;
            // 
            // btnSetEntranceTime
            // 
            this.btnSetEntranceTime.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnSetEntranceTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetEntranceTime.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetEntranceTime.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSetEntranceTime.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSetEntranceTime.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSetEntranceTime.IsBolded = false;
            this.btnSetEntranceTime.IsHoliday = false;
            this.btnSetEntranceTime.IsTrailing = false;
            this.btnSetEntranceTime.Location = new System.Drawing.Point(524, 41);
            this.btnSetEntranceTime.Name = "btnSetEntranceTime";
            this.btnSetEntranceTime.PushedAlways = false;
            this.btnSetEntranceTime.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSetEntranceTime.SecondBorderDistanceToEdge = 3F;
            this.btnSetEntranceTime.SecondBorderWidth = 3F;
            this.btnSetEntranceTime.ShowFirstBorder = true;
            this.btnSetEntranceTime.ShowSecondBorder = false;
            this.btnSetEntranceTime.Size = new System.Drawing.Size(69, 23);
            this.btnSetEntranceTime.Style = BehComponents.ButtonX.ButtonStyles.Green;
            this.btnSetEntranceTime.TabIndex = 1;
            this.btnSetEntranceTime.Text = "ورود";
            this.btnSetEntranceTime.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSetEntranceTime.UseVisualStyleBackColor = true;
            this.btnSetEntranceTime.Click += new System.EventHandler(this.btnSetEntranceTime_Click);
            // 
            // btnSetExitTime
            // 
            this.btnSetExitTime.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSetExitTime.BoldedForeColor = System.Drawing.Color.MediumBlue;
            this.btnSetExitTime.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetExitTime.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSetExitTime.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSetExitTime.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSetExitTime.IsBolded = false;
            this.btnSetExitTime.IsHoliday = false;
            this.btnSetExitTime.IsTrailing = false;
            this.btnSetExitTime.Location = new System.Drawing.Point(448, 41);
            this.btnSetExitTime.Name = "btnSetExitTime";
            this.btnSetExitTime.PushedAlways = false;
            this.btnSetExitTime.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSetExitTime.SecondBorderDistanceToEdge = 3F;
            this.btnSetExitTime.SecondBorderWidth = 3F;
            this.btnSetExitTime.ShowFirstBorder = true;
            this.btnSetExitTime.ShowSecondBorder = false;
            this.btnSetExitTime.Size = new System.Drawing.Size(70, 23);
            this.btnSetExitTime.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btnSetExitTime.TabIndex = 2;
            this.btnSetExitTime.Text = "خروج";
            this.btnSetExitTime.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSetExitTime.UseVisualStyleBackColor = false;
            this.btnSetExitTime.Click += new System.EventHandler(this.btnSetExitTime_Click);
            // 
            // btnSetInLegalLeave
            // 
            this.btnSetInLegalLeave.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnSetInLegalLeave.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetInLegalLeave.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSetInLegalLeave.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSetInLegalLeave.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSetInLegalLeave.IsBolded = false;
            this.btnSetInLegalLeave.IsHoliday = false;
            this.btnSetInLegalLeave.IsTrailing = false;
            this.btnSetInLegalLeave.Location = new System.Drawing.Point(4, 41);
            this.btnSetInLegalLeave.Name = "btnSetInLegalLeave";
            this.btnSetInLegalLeave.PushedAlways = false;
            this.btnSetInLegalLeave.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSetInLegalLeave.SecondBorderDistanceToEdge = 3F;
            this.btnSetInLegalLeave.SecondBorderWidth = 3F;
            this.btnSetInLegalLeave.ShowFirstBorder = true;
            this.btnSetInLegalLeave.ShowSecondBorder = false;
            this.btnSetInLegalLeave.Size = new System.Drawing.Size(86, 23);
            this.btnSetInLegalLeave.Style = BehComponents.ButtonX.ButtonStyles.Simple;
            this.btnSetInLegalLeave.TabIndex = 4;
            this.btnSetInLegalLeave.Text = "استحقاقی";
            this.btnSetInLegalLeave.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSetInLegalLeave.UseVisualStyleBackColor = true;
            this.btnSetInLegalLeave.Click += new System.EventHandler(this.setAbsenceTypeButtons_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainMenu.Size = new System.Drawing.Size(597, 34);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddEmployee,
            this.mnuModifyEmployees,
            this.mnuReports});
            this.mnuAdmin.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(50, 30);
            this.mnuAdmin.Text = "مدیر";
            // 
            // mnuAddEmployee
            // 
            this.mnuAddEmployee.Name = "mnuAddEmployee";
            this.mnuAddEmployee.Size = new System.Drawing.Size(162, 30);
            this.mnuAddEmployee.Text = "افزودن";
            this.mnuAddEmployee.Click += new System.EventHandler(this.mnuAddEmployee_Click);
            // 
            // mnuModifyEmployees
            // 
            this.mnuModifyEmployees.Name = "mnuModifyEmployees";
            this.mnuModifyEmployees.Size = new System.Drawing.Size(162, 30);
            this.mnuModifyEmployees.Text = "ویرایش اسامی";
            this.mnuModifyEmployees.Click += new System.EventHandler(this.mnuModifyEmployees_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(162, 30);
            this.mnuReports.Text = "گزارش گیری";
            this.mnuReports.Click += new System.EventHandler(this.mnuReports_Click);
            // 
            // btnSetOnAMission
            // 
            this.btnSetOnAMission.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnSetOnAMission.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetOnAMission.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSetOnAMission.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSetOnAMission.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSetOnAMission.IsBolded = false;
            this.btnSetOnAMission.IsHoliday = false;
            this.btnSetOnAMission.IsTrailing = false;
            this.btnSetOnAMission.Location = new System.Drawing.Point(96, 41);
            this.btnSetOnAMission.Name = "btnSetOnAMission";
            this.btnSetOnAMission.PushedAlways = false;
            this.btnSetOnAMission.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSetOnAMission.SecondBorderDistanceToEdge = 3F;
            this.btnSetOnAMission.SecondBorderWidth = 3F;
            this.btnSetOnAMission.ShowFirstBorder = true;
            this.btnSetOnAMission.ShowSecondBorder = false;
            this.btnSetOnAMission.Size = new System.Drawing.Size(78, 23);
            this.btnSetOnAMission.Style = BehComponents.ButtonX.ButtonStyles.Simple;
            this.btnSetOnAMission.TabIndex = 6;
            this.btnSetOnAMission.Text = "ماموریت";
            this.btnSetOnAMission.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSetOnAMission.UseVisualStyleBackColor = true;
            this.btnSetOnAMission.Click += new System.EventHandler(this.setAbsenceTypeButtons_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // btnHourlyBreak
            // 
            this.btnHourlyBreak.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnHourlyBreak.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnHourlyBreak.HolidayForeColor = System.Drawing.Color.Red;
            this.btnHourlyBreak.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnHourlyBreak.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnHourlyBreak.IsBolded = false;
            this.btnHourlyBreak.IsHoliday = false;
            this.btnHourlyBreak.IsTrailing = false;
            this.btnHourlyBreak.Location = new System.Drawing.Point(180, 41);
            this.btnHourlyBreak.Name = "btnHourlyBreak";
            this.btnHourlyBreak.PushedAlways = false;
            this.btnHourlyBreak.SecondBorderColor = System.Drawing.Color.Red;
            this.btnHourlyBreak.SecondBorderDistanceToEdge = 3F;
            this.btnHourlyBreak.SecondBorderWidth = 3F;
            this.btnHourlyBreak.ShowFirstBorder = true;
            this.btnHourlyBreak.ShowSecondBorder = false;
            this.btnHourlyBreak.Size = new System.Drawing.Size(78, 23);
            this.btnHourlyBreak.Style = BehComponents.ButtonX.ButtonStyles.Simple;
            this.btnHourlyBreak.TabIndex = 7;
            this.btnHourlyBreak.Text = "ساعتی";
            this.btnHourlyBreak.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnHourlyBreak.UseVisualStyleBackColor = true;
            this.btnHourlyBreak.Click += new System.EventHandler(this.btnHourlyBreak_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(597, 709);
            this.Controls.Add(this.btnHourlyBreak);
            this.Controls.Add(this.btnSetOnAMission);
            this.Controls.Add(this.btnSetInLegalLeave);
            this.Controls.Add(this.btnSetExitTime);
            this.Controls.Add(this.btnSetEntranceTime);
            this.Controls.Add(this.gridEmployees);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "ورود و خروج رسمی";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployees)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BehComponents.DataGridViewX gridEmployees;
        private BehComponents.ButtonX btnSetEntranceTime;
        private BehComponents.ButtonX btnSetExitTime;
        private BehComponents.ButtonX btnSetInLegalLeave;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuAddEmployee;
        private BehComponents.ButtonX btnSetOnAMission;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.ToolStripMenuItem mnuReports;
        private System.Windows.Forms.ToolStripMenuItem mnuModifyEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrace;
        private System.Windows.Forms.DataGridViewTextBoxColumn exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn absenceType;
        private BehComponents.ButtonX btnHourlyBreak;

    }
}

