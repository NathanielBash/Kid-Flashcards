namespace Word_Flash_Cards
{
    partial class CountingForm
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnSubtract1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnAdd10 = new System.Windows.Forms.Button();
            this.btnSubtract10 = new System.Windows.Forms.Button();
            this.btnAdd100 = new System.Windows.Forms.Button();
            this.btnSubtract100 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(307, 62);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(98, 108);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "0";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubtract1
            // 
            this.btnSubtract1.Location = new System.Drawing.Point(358, 233);
            this.btnSubtract1.Name = "btnSubtract1";
            this.btnSubtract1.Size = new System.Drawing.Size(69, 38);
            this.btnSubtract1.TabIndex = 1;
            this.btnSubtract1.Text = "Subtract\r\n 1\r\n";
            this.btnSubtract1.UseVisualStyleBackColor = true;
            this.btnSubtract1.Click += new System.EventHandler(this.btnSubtract1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(274, 233);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(78, 38);
            this.btnAdd1.TabIndex = 0;
            this.btnAdd1.Text = "Add \r\n 1\r\n";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(101, 183);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(511, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(317, 396);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(78, 38);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Random\r\nNumber";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnAdd10
            // 
            this.btnAdd10.Enabled = false;
            this.btnAdd10.Location = new System.Drawing.Point(274, 277);
            this.btnAdd10.Name = "btnAdd10";
            this.btnAdd10.Size = new System.Drawing.Size(78, 38);
            this.btnAdd10.TabIndex = 2;
            this.btnAdd10.Text = "Add \r\n 10";
            this.btnAdd10.UseVisualStyleBackColor = true;
            this.btnAdd10.Visible = false;
            this.btnAdd10.Click += new System.EventHandler(this.btnAdd10_Click_1);
            // 
            // btnSubtract10
            // 
            this.btnSubtract10.Enabled = false;
            this.btnSubtract10.Location = new System.Drawing.Point(358, 277);
            this.btnSubtract10.Name = "btnSubtract10";
            this.btnSubtract10.Size = new System.Drawing.Size(69, 38);
            this.btnSubtract10.TabIndex = 3;
            this.btnSubtract10.Text = "Subtract\r\n 10";
            this.btnSubtract10.UseVisualStyleBackColor = true;
            this.btnSubtract10.Visible = false;
            this.btnSubtract10.Click += new System.EventHandler(this.btnSubtract10_Click_1);
            // 
            // btnAdd100
            // 
            this.btnAdd100.Enabled = false;
            this.btnAdd100.Location = new System.Drawing.Point(274, 321);
            this.btnAdd100.Name = "btnAdd100";
            this.btnAdd100.Size = new System.Drawing.Size(78, 38);
            this.btnAdd100.TabIndex = 4;
            this.btnAdd100.Text = "Add \r\n 100";
            this.btnAdd100.UseVisualStyleBackColor = true;
            this.btnAdd100.Visible = false;
            this.btnAdd100.Click += new System.EventHandler(this.btnAdd100_Click_1);
            // 
            // btnSubtract100
            // 
            this.btnSubtract100.Enabled = false;
            this.btnSubtract100.Location = new System.Drawing.Point(358, 321);
            this.btnSubtract100.Name = "btnSubtract100";
            this.btnSubtract100.Size = new System.Drawing.Size(69, 38);
            this.btnSubtract100.TabIndex = 5;
            this.btnSubtract100.Text = "Subtract\r\n 100";
            this.btnSubtract100.UseVisualStyleBackColor = true;
            this.btnSubtract100.Visible = false;
            this.btnSubtract100.Click += new System.EventHandler(this.btnSubtract100_Click_1);
            // 
            // CountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 576);
            this.Controls.Add(this.btnAdd100);
            this.Controls.Add(this.btnSubtract100);
            this.Controls.Add(this.btnAdd10);
            this.Controls.Add(this.btnSubtract10);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.btnSubtract1);
            this.Controls.Add(this.lblNumber);
            this.Name = "CountingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counting";
            this.Load += new System.EventHandler(this.CountingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnSubtract1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnAdd10;
        private System.Windows.Forms.Button btnSubtract10;
        private System.Windows.Forms.Button btnAdd100;
        private System.Windows.Forms.Button btnSubtract100;
    }
}