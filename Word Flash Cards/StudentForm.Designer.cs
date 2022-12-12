namespace Word_Flash_Cards
{
    partial class StudentForm
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
            this.lblStudentFirstName = new System.Windows.Forms.Label();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.grpStudentName = new System.Windows.Forms.GroupBox();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.lblStudentLastName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.birthdayCalander = new System.Windows.Forms.MonthCalendar();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblStudentMonth = new System.Windows.Forms.Label();
            this.lblStudentDay = new System.Windows.Forms.Label();
            this.lblStudentYear = new System.Windows.Forms.Label();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.grpDemographic = new System.Windows.Forms.GroupBox();
            this.rbtnGirl = new System.Windows.Forms.RadioButton();
            this.rbtnBoy = new System.Windows.Forms.RadioButton();
            this.grpStudentName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpDemographic.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentFirstName
            // 
            this.lblStudentFirstName.AutoSize = true;
            this.lblStudentFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentFirstName.Location = new System.Drawing.Point(39, 28);
            this.lblStudentFirstName.Name = "lblStudentFirstName";
            this.lblStudentFirstName.Size = new System.Drawing.Size(96, 20);
            this.lblStudentFirstName.TabIndex = 13;
            this.lblStudentFirstName.Text = "First Name";
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentFirstName.Location = new System.Drawing.Point(30, 47);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(114, 26);
            this.txtStudentFirstName.TabIndex = 0;
            // 
            // grpStudentName
            // 
            this.grpStudentName.Controls.Add(this.txtStudentLastName);
            this.grpStudentName.Controls.Add(this.lblStudentLastName);
            this.grpStudentName.Controls.Add(this.txtStudentFirstName);
            this.grpStudentName.Controls.Add(this.lblStudentFirstName);
            this.grpStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentName.Location = new System.Drawing.Point(200, 12);
            this.grpStudentName.Name = "grpStudentName";
            this.grpStudentName.Size = new System.Drawing.Size(340, 122);
            this.grpStudentName.TabIndex = 14;
            this.grpStudentName.TabStop = false;
            this.grpStudentName.Text = "Your name";
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentLastName.Location = new System.Drawing.Point(170, 47);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(114, 26);
            this.txtStudentLastName.TabIndex = 1;
            // 
            // lblStudentLastName
            // 
            this.lblStudentLastName.AutoSize = true;
            this.lblStudentLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentLastName.Location = new System.Drawing.Point(179, 28);
            this.lblStudentLastName.Name = "lblStudentLastName";
            this.lblStudentLastName.Size = new System.Drawing.Size(95, 20);
            this.lblStudentLastName.TabIndex = 15;
            this.lblStudentLastName.Text = "Last Name";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(370, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(200, 531);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // birthdayCalander
            // 
            this.birthdayCalander.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayCalander.Location = new System.Drawing.Point(51, 149);
            this.birthdayCalander.Name = "birthdayCalander";
            this.birthdayCalander.TabIndex = 4;
            this.birthdayCalander.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.birthdayCalander_DateChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(9, 106);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 28);
            this.cmbMonth.TabIndex = 1;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(200, 105);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(114, 26);
            this.txtYear.TabIndex = 0;
            // 
            // lblStudentMonth
            // 
            this.lblStudentMonth.AutoSize = true;
            this.lblStudentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentMonth.Location = new System.Drawing.Point(40, 87);
            this.lblStudentMonth.Name = "lblStudentMonth";
            this.lblStudentMonth.Size = new System.Drawing.Size(49, 16);
            this.lblStudentMonth.TabIndex = 24;
            this.lblStudentMonth.Text = "Month";
            // 
            // lblStudentDay
            // 
            this.lblStudentDay.AutoSize = true;
            this.lblStudentDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDay.Location = new System.Drawing.Point(147, 83);
            this.lblStudentDay.Name = "lblStudentDay";
            this.lblStudentDay.Size = new System.Drawing.Size(40, 20);
            this.lblStudentDay.TabIndex = 25;
            this.lblStudentDay.Text = "Day";
            // 
            // lblStudentYear
            // 
            this.lblStudentYear.AutoSize = true;
            this.lblStudentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentYear.Location = new System.Drawing.Point(227, 87);
            this.lblStudentYear.Name = "lblStudentYear";
            this.lblStudentYear.Size = new System.Drawing.Size(47, 20);
            this.lblStudentYear.TabIndex = 26;
            this.lblStudentYear.Text = "Year";
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAge.Location = new System.Drawing.Point(147, 41);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(41, 20);
            this.lblStudentAge.TabIndex = 28;
            this.lblStudentAge.Text = "Age";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDay);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.birthdayCalander);
            this.groupBox1.Controls.Add(this.lblStudentAge);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.lblStudentYear);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.lblStudentDay);
            this.groupBox1.Controls.Add(this.lblStudentMonth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(200, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 322);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your age and birthday";
            // 
            // txtDay
            // 
            this.txtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.Location = new System.Drawing.Point(143, 105);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(50, 26);
            this.txtDay.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(143, 64);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(50, 22);
            this.txtAge.TabIndex = 0;
            // 
            // grpDemographic
            // 
            this.grpDemographic.Controls.Add(this.rbtnGirl);
            this.grpDemographic.Controls.Add(this.rbtnBoy);
            this.grpDemographic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDemographic.Location = new System.Drawing.Point(272, 140);
            this.grpDemographic.Name = "grpDemographic";
            this.grpDemographic.Size = new System.Drawing.Size(186, 57);
            this.grpDemographic.TabIndex = 16;
            this.grpDemographic.TabStop = false;
            this.grpDemographic.Text = "Are you a boy or girl?";
            // 
            // rbtnGirl
            // 
            this.rbtnGirl.AutoSize = true;
            this.rbtnGirl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGirl.Location = new System.Drawing.Point(111, 27);
            this.rbtnGirl.Name = "rbtnGirl";
            this.rbtnGirl.Size = new System.Drawing.Size(51, 24);
            this.rbtnGirl.TabIndex = 1;
            this.rbtnGirl.TabStop = true;
            this.rbtnGirl.Text = "Girl";
            this.rbtnGirl.UseVisualStyleBackColor = true;
            // 
            // rbtnBoy
            // 
            this.rbtnBoy.AutoSize = true;
            this.rbtnBoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBoy.Location = new System.Drawing.Point(18, 27);
            this.rbtnBoy.Name = "rbtnBoy";
            this.rbtnBoy.Size = new System.Drawing.Size(54, 24);
            this.rbtnBoy.TabIndex = 0;
            this.rbtnBoy.TabStop = true;
            this.rbtnBoy.Text = "Boy";
            this.rbtnBoy.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 576);
            this.Controls.Add(this.grpDemographic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpStudentName);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.grpStudentName.ResumeLayout(false);
            this.grpStudentName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDemographic.ResumeLayout(false);
            this.grpDemographic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblStudentFirstName;
        internal System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.GroupBox grpStudentName;
        internal System.Windows.Forms.TextBox txtStudentLastName;
        internal System.Windows.Forms.Label lblStudentLastName;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MonthCalendar birthdayCalander;
        private System.Windows.Forms.ComboBox cmbMonth;
        internal System.Windows.Forms.TextBox txtYear;
        internal System.Windows.Forms.Label lblStudentMonth;
        internal System.Windows.Forms.Label lblStudentDay;
        internal System.Windows.Forms.Label lblStudentYear;
        internal System.Windows.Forms.Label lblStudentAge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpDemographic;
        private System.Windows.Forms.RadioButton rbtnGirl;
        private System.Windows.Forms.RadioButton rbtnBoy;
        internal System.Windows.Forms.TextBox txtDay;
        internal System.Windows.Forms.TextBox txtAge;
    }
}