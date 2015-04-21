namespace Assignment06
{
    partial class SalesBonusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonusForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.TotalMonthlySales = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.LanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.RadioFrench = new System.Windows.Forms.RadioButton();
            this.RadioEnglish = new System.Windows.Forms.RadioButton();
            this.FrancaisLabel = new System.Windows.Forms.Label();
            this.EnglishLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.groupBox1.SuspendLayout();
            this.LanguageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SalesBonusTextBox);
            this.groupBox1.Controls.Add(this.TotalMonthlySales);
            this.groupBox1.Controls.Add(this.hoursWorkedTextBox);
            this.groupBox1.Controls.Add(this.employeeIdTextBox);
            this.groupBox1.Controls.Add(this.employeeNameTextBox);
            this.groupBox1.Controls.Add(this.SalesBonusLabel);
            this.groupBox1.Controls.Add(this.TotalSalesLabel);
            this.groupBox1.Controls.Add(this.HoursWorkedLabel);
            this.groupBox1.Controls.Add(this.EmployeeIDLabel);
            this.groupBox1.Controls.Add(this.EmployeeNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(60, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(468, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(208, 178);
            this.SalesBonusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(132, 22);
            this.SalesBonusTextBox.TabIndex = 1;
            this.SalesBonusTextBox.TextChanged += new System.EventHandler(this.SalesBonusTextBox_TextChanged);
            // 
            // TotalMonthlySales
            // 
            this.TotalMonthlySales.Location = new System.Drawing.Point(208, 138);
            this.TotalMonthlySales.Margin = new System.Windows.Forms.Padding(4);
            this.TotalMonthlySales.Name = "TotalMonthlySales";
            this.TotalMonthlySales.Size = new System.Drawing.Size(132, 22);
            this.TotalMonthlySales.TabIndex = 1;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(208, 97);
            this.hoursWorkedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hoursWorkedTextBox.MaxLength = 3;
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(132, 22);
            this.hoursWorkedTextBox.TabIndex = 1;
            this.hoursWorkedTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(208, 57);
            this.employeeIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(132, 22);
            this.employeeIdTextBox.TabIndex = 1;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(208, 16);
            this.employeeNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(243, 22);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(111, 182);
            this.SalesBonusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(87, 17);
            this.SalesBonusLabel.TabIndex = 0;
            this.SalesBonusLabel.Text = "Sales Bonus";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(67, 142);
            this.TotalSalesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(132, 17);
            this.TotalSalesLabel.TabIndex = 0;
            this.TotalSalesLabel.Text = "Total Monthly Sales";
            this.TotalSalesLabel.Click += new System.EventHandler(this.TotalSalesLabel_Click);
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(63, 101);
            this.HoursWorkedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(135, 17);
            this.HoursWorkedLabel.TabIndex = 0;
            this.HoursWorkedLabel.Text = "Total Hours Worked";
            this.HoursWorkedLabel.Click += new System.EventHandler(this.HoursWorkedLabel_Click);
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(111, 60);
            this.EmployeeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(87, 17);
            this.EmployeeIDLabel.TabIndex = 0;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(88, 20);
            this.EmployeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(111, 17);
            this.EmployeeNameLabel.TabIndex = 0;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // LanguageGroupBox
            // 
            this.LanguageGroupBox.Controls.Add(this.RadioFrench);
            this.LanguageGroupBox.Controls.Add(this.RadioEnglish);
            this.LanguageGroupBox.Controls.Add(this.FrancaisLabel);
            this.LanguageGroupBox.Controls.Add(this.EnglishLabel);
            this.LanguageGroupBox.Location = new System.Drawing.Point(207, 16);
            this.LanguageGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.LanguageGroupBox.Name = "LanguageGroupBox";
            this.LanguageGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.LanguageGroupBox.Size = new System.Drawing.Size(259, 123);
            this.LanguageGroupBox.TabIndex = 1;
            this.LanguageGroupBox.TabStop = false;
            // 
            // RadioFrench
            // 
            this.RadioFrench.AutoSize = true;
            this.RadioFrench.Location = new System.Drawing.Point(33, 74);
            this.RadioFrench.Margin = new System.Windows.Forms.Padding(4);
            this.RadioFrench.Name = "RadioFrench";
            this.RadioFrench.Size = new System.Drawing.Size(17, 16);
            this.RadioFrench.TabIndex = 1;
            this.RadioFrench.UseVisualStyleBackColor = true;
            // 
            // RadioEnglish
            // 
            this.RadioEnglish.AutoSize = true;
            this.RadioEnglish.Checked = true;
            this.RadioEnglish.Location = new System.Drawing.Point(33, 34);
            this.RadioEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.RadioEnglish.Name = "RadioEnglish";
            this.RadioEnglish.Size = new System.Drawing.Size(17, 16);
            this.RadioEnglish.TabIndex = 1;
            this.RadioEnglish.TabStop = true;
            this.RadioEnglish.UseVisualStyleBackColor = true;
            // 
            // FrancaisLabel
            // 
            this.FrancaisLabel.AutoSize = true;
            this.FrancaisLabel.Location = new System.Drawing.Point(79, 74);
            this.FrancaisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FrancaisLabel.Name = "FrancaisLabel";
            this.FrancaisLabel.Size = new System.Drawing.Size(62, 17);
            this.FrancaisLabel.TabIndex = 0;
            this.FrancaisLabel.Text = "Francais";
            // 
            // EnglishLabel
            // 
            this.EnglishLabel.AutoSize = true;
            this.EnglishLabel.Location = new System.Drawing.Point(79, 34);
            this.EnglishLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnglishLabel.Name = "EnglishLabel";
            this.EnglishLabel.Size = new System.Drawing.Size(54, 17);
            this.EnglishLabel.TabIndex = 0;
            this.EnglishLabel.Text = "English";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 379);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment06.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // SalesBonusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LanguageGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalesBonusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LanguageGroupBox.ResumeLayout(false);
            this.LanguageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.TextBox TotalMonthlySales;
        private System.Windows.Forms.TextBox hoursWorkedTextBox;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.GroupBox LanguageGroupBox;
        private System.Windows.Forms.RadioButton RadioFrench;
        private System.Windows.Forms.RadioButton RadioEnglish;
        private System.Windows.Forms.Label FrancaisLabel;
        private System.Windows.Forms.Label EnglishLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;

    }
}

