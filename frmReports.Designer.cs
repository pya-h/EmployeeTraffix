namespace EmployeeTraffix
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFrom = new BehComponents.DateTimePickerX();
            this.dtpUntil = new BehComponents.DateTimePickerX();
            this.gridTraffix = new BehComponents.DataGridViewX(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsOptionsContainer = new System.Windows.Forms.ToolStrip();
            this.pgbExporting = new System.Windows.Forms.ToolStripProgressBar();
            this.tsBtnExportExcel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridTraffix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tsOptionsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.AnchorSize = new System.Drawing.Size(300, 35);
            this.dtpFrom.BackColor = System.Drawing.Color.White;
            this.dtpFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpFrom.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpFrom.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dtpFrom.CalendarDayRectTickness = 2F;
            this.dtpFrom.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpFrom.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpFrom.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpFrom.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpFrom.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpFrom.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpFrom.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpFrom.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpFrom.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpFrom.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpFrom.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpFrom.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpFrom.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpFrom.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpFrom.CalendarShowToday = true;
            this.dtpFrom.CalendarShowTodayRect = true;
            this.dtpFrom.CalendarShowToolTips = false;
            this.dtpFrom.CalendarShowTrailing = true;
            this.dtpFrom.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpFrom.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpFrom.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpFrom.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpFrom.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpFrom.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dtpFrom.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpFrom.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dtpFrom.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpFrom.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpFrom.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpFrom.CalendarTodayRectTickness = 2F;
            this.dtpFrom.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpFrom.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpFrom.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dtpFrom.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpFrom.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dtpFrom.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpFrom.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpFrom.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpFrom.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpFrom.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpFrom.ClearButtonImage")));
            this.dtpFrom.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpFrom.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpFrom.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpFrom.ClearButtonText = "";
            this.dtpFrom.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpFrom.ClearButtonToolTip = "";
            this.dtpFrom.ClearButtonWidth = 17;
            this.dtpFrom.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpFrom.CustomFormat = "";
            this.dtpFrom.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpFrom.DropDownClosedWhenClickOnDays = false;
            this.dtpFrom.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpFrom.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpFrom.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dtpFrom.Format4Binding = "yyyy/MM/dd";
            this.dtpFrom.Location = new System.Drawing.Point(520, 15);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeftLayout = true;
            this.dtpFrom.ShowClearButton = false;
            this.dtpFrom.Size = new System.Drawing.Size(300, 35);
            this.dtpFrom.TabIndex = 8;
            this.dtpFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpFrom.TextWhenClearButtonClicked = "";
            this.dtpFrom.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.datePickers_SelectedDateChanged);
            // 
            // dtpUntil
            // 
            this.dtpUntil.AnchorSize = new System.Drawing.Size(300, 35);
            this.dtpUntil.BackColor = System.Drawing.Color.White;
            this.dtpUntil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpUntil.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpUntil.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dtpUntil.CalendarDayRectTickness = 2F;
            this.dtpUntil.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpUntil.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpUntil.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpUntil.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpUntil.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpUntil.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpUntil.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpUntil.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpUntil.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpUntil.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpUntil.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpUntil.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpUntil.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpUntil.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpUntil.CalendarShowToday = true;
            this.dtpUntil.CalendarShowTodayRect = true;
            this.dtpUntil.CalendarShowToolTips = false;
            this.dtpUntil.CalendarShowTrailing = true;
            this.dtpUntil.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpUntil.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpUntil.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpUntil.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpUntil.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpUntil.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpUntil.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dtpUntil.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpUntil.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpUntil.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dtpUntil.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpUntil.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpUntil.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpUntil.CalendarTodayRectTickness = 2F;
            this.dtpUntil.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpUntil.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpUntil.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dtpUntil.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpUntil.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dtpUntil.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpUntil.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpUntil.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpUntil.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpUntil.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpUntil.ClearButtonImage")));
            this.dtpUntil.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpUntil.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpUntil.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpUntil.ClearButtonText = "";
            this.dtpUntil.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpUntil.ClearButtonToolTip = "";
            this.dtpUntil.ClearButtonWidth = 17;
            this.dtpUntil.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpUntil.CustomFormat = "";
            this.dtpUntil.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpUntil.DropDownClosedWhenClickOnDays = false;
            this.dtpUntil.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpUntil.Font = new System.Drawing.Font("Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpUntil.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dtpUntil.Format4Binding = "yyyy/MM/dd";
            this.dtpUntil.Location = new System.Drawing.Point(12, 15);
            this.dtpUntil.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.RightToLeftLayout = true;
            this.dtpUntil.ShowClearButton = false;
            this.dtpUntil.Size = new System.Drawing.Size(300, 35);
            this.dtpUntil.TabIndex = 9;
            this.dtpUntil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpUntil.TextWhenClearButtonClicked = "";
            this.dtpUntil.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.datePickers_SelectedDateChanged);
            // 
            // gridTraffix
            // 
            this.gridTraffix.AllowUserToAddRows = false;
            this.gridTraffix.AllowUserToDeleteRows = false;
            this.gridTraffix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTraffix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTraffix.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridTraffix.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTraffix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTraffix.ColumnHeadersHeight = 40;
            this.gridTraffix.Columns_EnglishDate = ((System.Collections.Generic.List<string>)(resources.GetObject("gridTraffix.Columns_EnglishDate")));
            this.gridTraffix.Columns_PersianDate = ((System.Collections.Generic.List<string>)(resources.GetObject("gridTraffix.Columns_PersianDate")));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTraffix.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTraffix.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridTraffix.Location = new System.Drawing.Point(12, 68);
            this.gridTraffix.MultiSelect = false;
            this.gridTraffix.Name = "gridTraffix";
            this.gridTraffix.ReadOnly = true;
            this.gridTraffix.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridTraffix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTraffix.ShowEditingIcon = false;
            this.gridTraffix.Size = new System.Drawing.Size(808, 484);
            this.gridTraffix.TabIndex = 10;
            this.gridTraffix.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gridTraffix_DataBindingComplete);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tsOptionsContainer
            // 
            this.tsOptionsContainer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tsOptionsContainer.Dock = System.Windows.Forms.DockStyle.None;
            this.tsOptionsContainer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsOptionsContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pgbExporting,
            this.tsBtnExportExcel});
            this.tsOptionsContainer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsOptionsContainer.Location = new System.Drawing.Point(363, 508);
            this.tsOptionsContainer.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tsOptionsContainer.Name = "tsOptionsContainer";
            this.tsOptionsContainer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsOptionsContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsOptionsContainer.Size = new System.Drawing.Size(170, 39);
            this.tsOptionsContainer.TabIndex = 12;
            this.tsOptionsContainer.Text = "toolStrip1";
            // 
            // pgbExporting
            // 
            this.pgbExporting.Margin = new System.Windows.Forms.Padding(1, 8, 1, 1);
            this.pgbExporting.Name = "pgbExporting";
            this.pgbExporting.Size = new System.Drawing.Size(100, 15);
            this.pgbExporting.Visible = false;
            // 
            // tsBtnExportExcel
            // 
            this.tsBtnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExportExcel.Image")));
            this.tsBtnExportExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExportExcel.Name = "tsBtnExportExcel";
            this.tsBtnExportExcel.Size = new System.Drawing.Size(36, 36);
            this.tsBtnExportExcel.Click += new System.EventHandler(this.tsBtnExportExcel_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 556);
            this.Controls.Add(this.tsOptionsContainer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridTraffix);
            this.Controls.Add(this.dtpUntil);
            this.Controls.Add(this.dtpFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش گیری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTraffix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tsOptionsContainer.ResumeLayout(false);
            this.tsOptionsContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BehComponents.DateTimePickerX dtpFrom;
        private BehComponents.DateTimePickerX dtpUntil;
        private BehComponents.DataGridViewX gridTraffix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip tsOptionsContainer;
        private System.Windows.Forms.ToolStripProgressBar pgbExporting;
        private System.Windows.Forms.ToolStripButton tsBtnExportExcel;
    }
}