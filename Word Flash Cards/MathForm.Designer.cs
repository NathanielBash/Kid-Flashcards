namespace Word_Flash_Cards
{
    partial class MathForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.grpDifficulty = new System.Windows.Forms.GroupBox();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.rbtnIntermediate = new System.Windows.Forms.RadioButton();
            this.rbtnEasy = new System.Windows.Forms.RadioButton();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.lblProblemType = new System.Windows.Forms.Label();
            this.grpDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(260, 383);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 55);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(180, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(236, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.Location = new System.Drawing.Point(239, 302);
            this.lblResponse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(124, 25);
            this.lblResponse.TabIndex = 22;
            this.lblResponse.Text = "                ";
            // 
            // txtAnswer
            // 
            this.txtAnswer.AcceptsReturn = true;
            this.txtAnswer.Location = new System.Drawing.Point(260, 257);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(75, 20);
            this.txtAnswer.TabIndex = 0;
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTwo.Location = new System.Drawing.Point(335, 215);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(40, 24);
            this.lblNumberTwo.TabIndex = 21;
            this.lblNumberTwo.Text = "     ";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(277, 216);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(40, 24);
            this.lblOperator.TabIndex = 20;
            this.lblOperator.Text = "     ";
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOne.Location = new System.Drawing.Point(219, 216);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(40, 24);
            this.lblNumberOne.TabIndex = 19;
            this.lblNumberOne.Text = "     ";
            // 
            // grpDifficulty
            // 
            this.grpDifficulty.Controls.Add(this.rbtnHard);
            this.grpDifficulty.Controls.Add(this.rbtnIntermediate);
            this.grpDifficulty.Controls.Add(this.rbtnEasy);
            this.grpDifficulty.Location = new System.Drawing.Point(180, 51);
            this.grpDifficulty.Name = "grpDifficulty";
            this.grpDifficulty.Size = new System.Drawing.Size(236, 100);
            this.grpDifficulty.TabIndex = 13;
            this.grpDifficulty.TabStop = false;
            this.grpDifficulty.Text = "Select the difficulty";
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.Location = new System.Drawing.Point(21, 71);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(48, 17);
            this.rbtnHard.TabIndex = 2;
            this.rbtnHard.Text = "Hard";
            this.rbtnHard.UseVisualStyleBackColor = true;
            this.rbtnHard.CheckedChanged += new System.EventHandler(this.rbtnHard_CheckedChanged);
            // 
            // rbtnIntermediate
            // 
            this.rbtnIntermediate.AutoSize = true;
            this.rbtnIntermediate.Location = new System.Drawing.Point(21, 46);
            this.rbtnIntermediate.Name = "rbtnIntermediate";
            this.rbtnIntermediate.Size = new System.Drawing.Size(83, 17);
            this.rbtnIntermediate.TabIndex = 1;
            this.rbtnIntermediate.TabStop = true;
            this.rbtnIntermediate.Text = "Intermediate";
            this.rbtnIntermediate.UseVisualStyleBackColor = true;
            // 
            // rbtnEasy
            // 
            this.rbtnEasy.AutoSize = true;
            this.rbtnEasy.Checked = true;
            this.rbtnEasy.Location = new System.Drawing.Point(21, 23);
            this.rbtnEasy.Name = "rbtnEasy";
            this.rbtnEasy.Size = new System.Drawing.Size(48, 17);
            this.rbtnEasy.TabIndex = 0;
            this.rbtnEasy.TabStop = true;
            this.rbtnEasy.Text = "Easy";
            this.rbtnEasy.UseVisualStyleBackColor = true;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveUp.Location = new System.Drawing.Point(341, 383);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(75, 55);
            this.btnGiveUp.TabIndex = 2;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(180, 383);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(74, 55);
            this.btnAnswer.TabIndex = 1;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblProblemType
            // 
            this.lblProblemType.AutoSize = true;
            this.lblProblemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemType.Location = new System.Drawing.Point(247, 164);
            this.lblProblemType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProblemType.Name = "lblProblemType";
            this.lblProblemType.Size = new System.Drawing.Size(116, 25);
            this.lblProblemType.TabIndex = 15;
            this.lblProblemType.Text = "Math type";
            this.lblProblemType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 576);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblNumberTwo);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblNumberOne);
            this.Controls.Add(this.grpDifficulty);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.lblProblemType);
            this.Name = "MathForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math";
            this.grpDifficulty.ResumeLayout(false);
            this.grpDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Label lblResponse;
        internal System.Windows.Forms.TextBox txtAnswer;
        internal System.Windows.Forms.Label lblNumberTwo;
        internal System.Windows.Forms.Label lblOperator;
        internal System.Windows.Forms.Label lblNumberOne;
        internal System.Windows.Forms.GroupBox grpDifficulty;
        internal System.Windows.Forms.RadioButton rbtnHard;
        internal System.Windows.Forms.RadioButton rbtnIntermediate;
        internal System.Windows.Forms.RadioButton rbtnEasy;
        internal System.Windows.Forms.Button btnGiveUp;
        internal System.Windows.Forms.Button btnAnswer;
        internal System.Windows.Forms.Label lblProblemType;
    }
}