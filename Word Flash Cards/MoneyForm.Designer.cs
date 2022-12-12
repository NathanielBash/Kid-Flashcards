namespace Word_Flash_Cards
{
    partial class MoneyForm
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
            this.grpConis = new System.Windows.Forms.GroupBox();
            this.btnDime = new System.Windows.Forms.Button();
            this.btnQuarter = new System.Windows.Forms.Button();
            this.btnNickel = new System.Windows.Forms.Button();
            this.btnPenny = new System.Windows.Forms.Button();
            this.grpDollars = new System.Windows.Forms.GroupBox();
            this.btn100Dollar = new System.Windows.Forms.Button();
            this.btn50Dollar = new System.Windows.Forms.Button();
            this.btn20Dollar = new System.Windows.Forms.Button();
            this.btn10Dollar = new System.Windows.Forms.Button();
            this.btn5Dollar = new System.Windows.Forms.Button();
            this.btn2Dollar = new System.Windows.Forms.Button();
            this.btn1Dollar = new System.Windows.Forms.Button();
            this.picOneDollar = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.TallyBox = new System.Windows.Forms.ListBox();
            this.grpConis.SuspendLayout();
            this.grpDollars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOneDollar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConis
            // 
            this.grpConis.Controls.Add(this.btnDime);
            this.grpConis.Controls.Add(this.btnQuarter);
            this.grpConis.Controls.Add(this.btnNickel);
            this.grpConis.Controls.Add(this.btnPenny);
            this.grpConis.Location = new System.Drawing.Point(6, 181);
            this.grpConis.Name = "grpConis";
            this.grpConis.Size = new System.Drawing.Size(716, 126);
            this.grpConis.TabIndex = 0;
            this.grpConis.TabStop = false;
            this.grpConis.Text = "Coins";
            // 
            // btnDime
            // 
            this.btnDime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDime.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_Dime;
            this.btnDime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDime.Location = new System.Drawing.Point(410, 19);
            this.btnDime.Name = "btnDime";
            this.btnDime.Size = new System.Drawing.Size(100, 100);
            this.btnDime.TabIndex = 11;
            this.btnDime.UseVisualStyleBackColor = false;
            this.btnDime.Click += new System.EventHandler(this.btnDime_Click);
            // 
            // btnQuarter
            // 
            this.btnQuarter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuarter.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_Quarter;
            this.btnQuarter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuarter.Location = new System.Drawing.Point(611, 19);
            this.btnQuarter.Name = "btnQuarter";
            this.btnQuarter.Size = new System.Drawing.Size(100, 100);
            this.btnQuarter.TabIndex = 10;
            this.btnQuarter.UseVisualStyleBackColor = false;
            this.btnQuarter.Click += new System.EventHandler(this.btnQuarter_Click);
            // 
            // btnNickel
            // 
            this.btnNickel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNickel.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_Nickel;
            this.btnNickel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNickel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNickel.Location = new System.Drawing.Point(209, 19);
            this.btnNickel.Name = "btnNickel";
            this.btnNickel.Size = new System.Drawing.Size(100, 100);
            this.btnNickel.TabIndex = 9;
            this.btnNickel.UseVisualStyleBackColor = false;
            this.btnNickel.Click += new System.EventHandler(this.btnNickel_Click);
            // 
            // btnPenny
            // 
            this.btnPenny.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPenny.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_Penny;
            this.btnPenny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPenny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenny.Location = new System.Drawing.Point(8, 19);
            this.btnPenny.Name = "btnPenny";
            this.btnPenny.Size = new System.Drawing.Size(100, 100);
            this.btnPenny.TabIndex = 8;
            this.btnPenny.UseVisualStyleBackColor = false;
            this.btnPenny.Click += new System.EventHandler(this.btnPenny_Click);
            // 
            // grpDollars
            // 
            this.grpDollars.Controls.Add(this.btn100Dollar);
            this.grpDollars.Controls.Add(this.btn50Dollar);
            this.grpDollars.Controls.Add(this.btn20Dollar);
            this.grpDollars.Controls.Add(this.btn10Dollar);
            this.grpDollars.Controls.Add(this.btn5Dollar);
            this.grpDollars.Controls.Add(this.btn2Dollar);
            this.grpDollars.Controls.Add(this.btn1Dollar);
            this.grpDollars.Controls.Add(this.picOneDollar);
            this.grpDollars.Location = new System.Drawing.Point(6, 341);
            this.grpDollars.Name = "grpDollars";
            this.grpDollars.Size = new System.Drawing.Size(716, 189);
            this.grpDollars.TabIndex = 1;
            this.grpDollars.TabStop = false;
            this.grpDollars.Text = "Dollars";
            // 
            // btn100Dollar
            // 
            this.btn100Dollar.AccessibleName = "btnDollar";
            this.btn100Dollar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn100Dollar.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_100_Dollar;
            this.btn100Dollar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn100Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100Dollar.Location = new System.Drawing.Point(456, 98);
            this.btn100Dollar.Name = "btn100Dollar";
            this.btn100Dollar.Size = new System.Drawing.Size(158, 73);
            this.btn100Dollar.TabIndex = 19;
            this.btn100Dollar.UseVisualStyleBackColor = false;
            this.btn100Dollar.Click += new System.EventHandler(this.btn100Dollar_Click);
            // 
            // btn50Dollar
            // 
            this.btn50Dollar.AccessibleName = "btnDollar";
            this.btn50Dollar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn50Dollar.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_50_Dollar;
            this.btn50Dollar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn50Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50Dollar.Location = new System.Drawing.Point(280, 98);
            this.btn50Dollar.Name = "btn50Dollar";
            this.btn50Dollar.Size = new System.Drawing.Size(158, 73);
            this.btn50Dollar.TabIndex = 17;
            this.btn50Dollar.UseVisualStyleBackColor = false;
            this.btn50Dollar.Click += new System.EventHandler(this.btn50Dollar_Click);
            // 
            // btn20Dollar
            // 
            this.btn20Dollar.AccessibleName = "btnDollar";
            this.btn20Dollar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn20Dollar.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_20_Dollar;
            this.btn20Dollar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn20Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20Dollar.Location = new System.Drawing.Point(99, 98);
            this.btn20Dollar.Name = "btn20Dollar";
            this.btn20Dollar.Size = new System.Drawing.Size(158, 73);
            this.btn20Dollar.TabIndex = 16;
            this.btn20Dollar.UseVisualStyleBackColor = false;
            this.btn20Dollar.Click += new System.EventHandler(this.btn20Dollar_Click);
            // 
            // btn10Dollar
            // 
            this.btn10Dollar.AccessibleName = "btnDollar";
            this.btn10Dollar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn10Dollar.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_10_Dollar;
            this.btn10Dollar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn10Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10Dollar.Location = new System.Drawing.Point(555, 19);
            this.btn10Dollar.Name = "btn10Dollar";
            this.btn10Dollar.Size = new System.Drawing.Size(158, 73);
            this.btn10Dollar.TabIndex = 15;
            this.btn10Dollar.UseVisualStyleBackColor = false;
            this.btn10Dollar.Click += new System.EventHandler(this.btn10Dollar_Click);
            // 
            // btn5Dollar
            // 
            this.btn5Dollar.AccessibleName = "btnDollar";
            this.btn5Dollar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn5Dollar.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_5_Dollar;
            this.btn5Dollar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Dollar.Location = new System.Drawing.Point(374, 19);
            this.btn5Dollar.Name = "btn5Dollar";
            this.btn5Dollar.Size = new System.Drawing.Size(158, 73);
            this.btn5Dollar.TabIndex = 14;
            this.btn5Dollar.UseVisualStyleBackColor = false;
            this.btn5Dollar.Click += new System.EventHandler(this.btn5Dollar_Click);
            // 
            // btn2Dollar
            // 
            this.btn2Dollar.AccessibleName = "btnDollar";
            this.btn2Dollar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn2Dollar.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_2_Dollar;
            this.btn2Dollar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Dollar.Location = new System.Drawing.Point(193, 19);
            this.btn2Dollar.Name = "btn2Dollar";
            this.btn2Dollar.Size = new System.Drawing.Size(158, 73);
            this.btn2Dollar.TabIndex = 13;
            this.btn2Dollar.UseVisualStyleBackColor = false;
            this.btn2Dollar.Click += new System.EventHandler(this.btn2Dollar_Click);
            // 
            // btn1Dollar
            // 
            this.btn1Dollar.AccessibleName = "btnDollar";
            this.btn1Dollar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn1Dollar.BackgroundImage = global::Word_Flash_Cards.Properties.Resources.US_1_Dollar;
            this.btn1Dollar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1Dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Dollar.Location = new System.Drawing.Point(12, 19);
            this.btn1Dollar.Name = "btn1Dollar";
            this.btn1Dollar.Size = new System.Drawing.Size(158, 73);
            this.btn1Dollar.TabIndex = 12;
            this.btn1Dollar.UseVisualStyleBackColor = false;
            this.btn1Dollar.Click += new System.EventHandler(this.btn1Dollar_Click);
            // 
            // picOneDollar
            // 
            this.picOneDollar.Location = new System.Drawing.Point(6, 19);
            this.picOneDollar.Name = "picOneDollar";
            this.picOneDollar.Size = new System.Drawing.Size(0, 0);
            this.picOneDollar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOneDollar.TabIndex = 0;
            this.picOneDollar.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(320, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 24);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(333, 89);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(55, 24);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "$0.00";
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.Red;
            this.btnSubtract.Enabled = false;
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(545, 67);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(140, 53);
            this.btnSubtract.TabIndex = 5;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Visible = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(545, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(545, 126);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 53);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // TallyBox
            // 
            this.TallyBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TallyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TallyBox.FormattingEnabled = true;
            this.TallyBox.Location = new System.Drawing.Point(18, 12);
            this.TallyBox.Name = "TallyBox";
            this.TallyBox.Size = new System.Drawing.Size(148, 156);
            this.TallyBox.TabIndex = 8;
            // 
            // MoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 576);
            this.Controls.Add(this.TallyBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpDollars);
            this.Controls.Add(this.grpConis);
            this.Name = "MoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money";
            this.Load += new System.EventHandler(this.Money_Load);
            this.grpConis.ResumeLayout(false);
            this.grpDollars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOneDollar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConis;
        private System.Windows.Forms.GroupBox grpDollars;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.PictureBox picOneDollar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDime;
        private System.Windows.Forms.Button btnQuarter;
        private System.Windows.Forms.Button btnNickel;
        private System.Windows.Forms.Button btnPenny;
        private System.Windows.Forms.Button btn50Dollar;
        private System.Windows.Forms.Button btn20Dollar;
        private System.Windows.Forms.Button btn10Dollar;
        private System.Windows.Forms.Button btn5Dollar;
        private System.Windows.Forms.Button btn2Dollar;
        private System.Windows.Forms.Button btn1Dollar;
        private System.Windows.Forms.Button btn100Dollar;
        private System.Windows.Forms.ListBox TallyBox;
    }
}