namespace Word_Flash_Cards
{
    partial class FlashCardsForm
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
            this.ColorTimer = new System.Windows.Forms.Timer(this.components);
            this.txtWord = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SlowDown = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level4ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level6ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level7ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level8ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.countingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.additionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplcationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.typingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.level4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.level8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicalNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symbolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSignatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtTyping = new System.Windows.Forms.TextBox();
            this.nounsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verbsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjutivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostCommonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorTimer
            // 
            this.ColorTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtWord
            // 
            this.txtWord.AutoSize = true;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(143, 176);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(428, 73);
            this.txtWord.TabIndex = 0;
            this.txtWord.Text = "Reading time!";
            this.txtWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(256, 456);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 39);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next Word";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(350, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SlowDown
            // 
            this.SlowDown.Interval = 30;
            this.SlowDown.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordsToolStripMenuItem1,
            this.typingToolStripMenuItem,
            this.mathToolStripMenuItem1,
            this.colorsToolStripMenuItem1,
            this.shapesToolStripMenuItem1,
            this.musicToolStripMenuItem,
            this.moneyToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wordsToolStripMenuItem1
            // 
            this.wordsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostCommonToolStripMenuItem,
            this.level1ToolStripMenuItem1,
            this.level2ToolStripMenuItem,
            this.level3ToolStripMenuItem1,
            this.level4ToolStripMenuItem1,
            this.level5ToolStripMenuItem1,
            this.level6ToolStripMenuItem1,
            this.level7ToolStripMenuItem1,
            this.level8ToolStripMenuItem1,
            this.level9ToolStripMenuItem,
            this.nounsToolStripMenuItem,
            this.verbsToolStripMenuItem,
            this.adjutivesToolStripMenuItem,
            this.prepositionsToolStripMenuItem});
            this.wordsToolStripMenuItem1.Name = "wordsToolStripMenuItem1";
            this.wordsToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.wordsToolStripMenuItem1.Text = "Flash &Words";
            // 
            // level1ToolStripMenuItem1
            // 
            this.level1ToolStripMenuItem1.Name = "level1ToolStripMenuItem1";
            this.level1ToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.level1ToolStripMenuItem1.Tag = "Level 1";
            this.level1ToolStripMenuItem1.Text = "Level A";
            this.level1ToolStripMenuItem1.Click += new System.EventHandler(this.level1ToolStripMenuItem1_Click_1);
            // 
            // level2ToolStripMenuItem
            // 
            this.level2ToolStripMenuItem.Name = "level2ToolStripMenuItem";
            this.level2ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.level2ToolStripMenuItem.Tag = "Level 2";
            this.level2ToolStripMenuItem.Text = "Level &B";
            this.level2ToolStripMenuItem.Click += new System.EventHandler(this.level2ToolStripMenuItem_Click);
            // 
            // level3ToolStripMenuItem1
            // 
            this.level3ToolStripMenuItem1.Name = "level3ToolStripMenuItem1";
            this.level3ToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.level3ToolStripMenuItem1.Tag = "Level 3";
            this.level3ToolStripMenuItem1.Text = "Level &C";
            this.level3ToolStripMenuItem1.Click += new System.EventHandler(this.level3ToolStripMenuItem1_Click);
            // 
            // level4ToolStripMenuItem1
            // 
            this.level4ToolStripMenuItem1.Name = "level4ToolStripMenuItem1";
            this.level4ToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.level4ToolStripMenuItem1.Tag = "Level 4";
            this.level4ToolStripMenuItem1.Text = "&Phonics";
            this.level4ToolStripMenuItem1.Click += new System.EventHandler(this.level4ToolStripMenuItem1_Click);
            // 
            // level5ToolStripMenuItem1
            // 
            this.level5ToolStripMenuItem1.Name = "level5ToolStripMenuItem1";
            this.level5ToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.level5ToolStripMenuItem1.Tag = "Level 5";
            this.level5ToolStripMenuItem1.Text = "&Vocab Builder";
            this.level5ToolStripMenuItem1.Click += new System.EventHandler(this.level5ToolStripMenuItem1_Click);
            // 
            // level6ToolStripMenuItem1
            // 
            this.level6ToolStripMenuItem1.Name = "level6ToolStripMenuItem1";
            this.level6ToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.level6ToolStripMenuItem1.Tag = "Level 6";
            this.level6ToolStripMenuItem1.Text = "&Dolch words";
            this.level6ToolStripMenuItem1.Click += new System.EventHandler(this.level6ToolStripMenuItem1_Click);
            // 
            // level7ToolStripMenuItem1
            // 
            this.level7ToolStripMenuItem1.Name = "level7ToolStripMenuItem1";
            this.level7ToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.level7ToolStripMenuItem1.Tag = "Level 7";
            this.level7ToolStripMenuItem1.Text = "Word Familes";
            this.level7ToolStripMenuItem1.Click += new System.EventHandler(this.level7ToolStripMenuItem1_Click);
            // 
            // level8ToolStripMenuItem1
            // 
            this.level8ToolStripMenuItem1.Name = "level8ToolStripMenuItem1";
            this.level8ToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.level8ToolStripMenuItem1.Tag = "Level 8";
            this.level8ToolStripMenuItem1.Text = "&Action Verbs A to Z";
            this.level8ToolStripMenuItem1.Click += new System.EventHandler(this.level8ToolStripMenuItem1_Click);
            // 
            // level9ToolStripMenuItem
            // 
            this.level9ToolStripMenuItem.Name = "level9ToolStripMenuItem";
            this.level9ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.level9ToolStripMenuItem.Tag = "Level 9";
            this.level9ToolStripMenuItem.Text = "&Phonics Practice";
            // 
            // mathToolStripMenuItem1
            // 
            this.mathToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countingToolStripMenuItem1,
            this.additionToolStripMenuItem1,
            this.subtractionToolStripMenuItem1,
            this.multiplcationToolStripMenuItem,
            this.divisonToolStripMenuItem});
            this.mathToolStripMenuItem1.Name = "mathToolStripMenuItem1";
            this.mathToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.mathToolStripMenuItem1.Text = "&Math";
            // 
            // countingToolStripMenuItem1
            // 
            this.countingToolStripMenuItem1.Name = "countingToolStripMenuItem1";
            this.countingToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.countingToolStripMenuItem1.Text = "&Counting";
            this.countingToolStripMenuItem1.Click += new System.EventHandler(this.countingToolStripMenuItem1_Click);
            // 
            // additionToolStripMenuItem1
            // 
            this.additionToolStripMenuItem1.Name = "additionToolStripMenuItem1";
            this.additionToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.additionToolStripMenuItem1.Text = "A&ddition";
            this.additionToolStripMenuItem1.Click += new System.EventHandler(this.additionToolStripMenuItem1_Click);
            // 
            // subtractionToolStripMenuItem1
            // 
            this.subtractionToolStripMenuItem1.Name = "subtractionToolStripMenuItem1";
            this.subtractionToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.subtractionToolStripMenuItem1.Text = "S&ubtraction";
            this.subtractionToolStripMenuItem1.Click += new System.EventHandler(this.subtractionToolStripMenuItem1_Click);
            // 
            // multiplcationToolStripMenuItem
            // 
            this.multiplcationToolStripMenuItem.Name = "multiplcationToolStripMenuItem";
            this.multiplcationToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.multiplcationToolStripMenuItem.Text = "M&ultiplcation";
            this.multiplcationToolStripMenuItem.Click += new System.EventHandler(this.multiplcationToolStripMenuItem_Click);
            // 
            // divisonToolStripMenuItem
            // 
            this.divisonToolStripMenuItem.Name = "divisonToolStripMenuItem";
            this.divisonToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.divisonToolStripMenuItem.Text = "D&ivison";
            this.divisonToolStripMenuItem.Click += new System.EventHandler(this.divisonToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem1
            // 
            this.colorsToolStripMenuItem1.Name = "colorsToolStripMenuItem1";
            this.colorsToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem1.Text = "&Colors";
            this.colorsToolStripMenuItem1.Click += new System.EventHandler(this.colorsToolStripMenuItem1_Click);
            // 
            // shapesToolStripMenuItem1
            // 
            this.shapesToolStripMenuItem1.Name = "shapesToolStripMenuItem1";
            this.shapesToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.shapesToolStripMenuItem1.Text = "&Shapes";
            this.shapesToolStripMenuItem1.Click += new System.EventHandler(this.shapesToolStripMenuItem1_Click);
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.musicToolStripMenuItem.Text = "&Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // moneyToolStripMenuItem
            // 
            this.moneyToolStripMenuItem.Name = "moneyToolStripMenuItem";
            this.moneyToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.moneyToolStripMenuItem.Text = "Mone&y";
            this.moneyToolStripMenuItem.Click += new System.EventHandler(this.moneyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // typingToolStripMenuItem
            // 
            this.typingToolStripMenuItem.Name = "typingToolStripMenuItem";
            this.typingToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.typingToolStripMenuItem.Text = "English";
            this.typingToolStripMenuItem.Visible = false;
            this.typingToolStripMenuItem.Click += new System.EventHandler(this.typingToolStripMenuItem_Click);
            // 
            // wordsToolStripMenuItem
            // 
            this.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem";
            this.wordsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.wordsToolStripMenuItem.Text = "&Words";
            // 
            // level1ToolStripMenuItem
            // 
            this.level1ToolStripMenuItem.Name = "level1ToolStripMenuItem";
            this.level1ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // level2ToolStripMenuItem1
            // 
            this.level2ToolStripMenuItem1.Name = "level2ToolStripMenuItem1";
            this.level2ToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // level3ToolStripMenuItem
            // 
            this.level3ToolStripMenuItem.Name = "level3ToolStripMenuItem";
            this.level3ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // worldToolStripMenuItem
            // 
            this.worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            this.worldToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // level4ToolStripMenuItem
            // 
            this.level4ToolStripMenuItem.Name = "level4ToolStripMenuItem";
            this.level4ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // level5ToolStripMenuItem
            // 
            this.level5ToolStripMenuItem.Name = "level5ToolStripMenuItem";
            this.level5ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // level6ToolStripMenuItem
            // 
            this.level6ToolStripMenuItem.Name = "level6ToolStripMenuItem";
            this.level6ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // level7ToolStripMenuItem
            // 
            this.level7ToolStripMenuItem.Name = "level7ToolStripMenuItem";
            this.level7ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // level8ToolStripMenuItem
            // 
            this.level8ToolStripMenuItem.Name = "level8ToolStripMenuItem";
            this.level8ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // mathToolStripMenuItem
            // 
            this.mathToolStripMenuItem.Name = "mathToolStripMenuItem";
            this.mathToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.mathToolStripMenuItem.Text = "&Math";
            // 
            // countingToolStripMenuItem
            // 
            this.countingToolStripMenuItem.Name = "countingToolStripMenuItem";
            this.countingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.countingToolStripMenuItem.Text = "&Counting";
            this.countingToolStripMenuItem.Click += new System.EventHandler(this.countingToolStripMenuItem_Click);
            // 
            // additionToolStripMenuItem
            // 
            this.additionToolStripMenuItem.Name = "additionToolStripMenuItem";
            this.additionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.additionToolStripMenuItem.Text = "&Addition";
            this.additionToolStripMenuItem.Click += new System.EventHandler(this.additionToolStripMenuItem_Click);
            // 
            // subtractionToolStripMenuItem
            // 
            this.subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            this.subtractionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subtractionToolStripMenuItem.Text = "&Subtraction";
            this.subtractionToolStripMenuItem.Click += new System.EventHandler(this.subtractionToolStripMenuItem_Click);
            // 
            // multiplicationToolStripMenuItem
            // 
            this.multiplicationToolStripMenuItem.Name = "multiplicationToolStripMenuItem";
            this.multiplicationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.multiplicationToolStripMenuItem.Text = "&Multiplication";
            this.multiplicationToolStripMenuItem.Click += new System.EventHandler(this.multiplicationToolStripMenuItem_Click);
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.divisionToolStripMenuItem.Text = "&Division";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "&Colors";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.shapesToolStripMenuItem.Text = "&Shapes";
            this.shapesToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // musicalNotesToolStripMenuItem
            // 
            this.musicalNotesToolStripMenuItem.Name = "musicalNotesToolStripMenuItem";
            this.musicalNotesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.musicalNotesToolStripMenuItem.Text = "Musical &Notes";
            // 
            // symbolsToolStripMenuItem
            // 
            this.symbolsToolStripMenuItem.Name = "symbolsToolStripMenuItem";
            this.symbolsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.symbolsToolStripMenuItem.Text = "&Symbols";
            this.symbolsToolStripMenuItem.Click += new System.EventHandler(this.symbolsToolStripMenuItem_Click);
            // 
            // timeSignatureToolStripMenuItem
            // 
            this.timeSignatureToolStripMenuItem.Name = "timeSignatureToolStripMenuItem";
            this.timeSignatureToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.timeSignatureToolStripMenuItem.Text = "&Time Signature";
            this.timeSignatureToolStripMenuItem.Click += new System.EventHandler(this.timeSignatureToolStripMenuItem_Click);
            // 
            // trebleToolStripMenuItem
            // 
            this.trebleToolStripMenuItem.Name = "trebleToolStripMenuItem";
            this.trebleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.trebleToolStripMenuItem.Text = "Tre&ble";
            this.trebleToolStripMenuItem.Click += new System.EventHandler(this.trebleToolStripMenuItem_Click);
            // 
            // bassToolStripMenuItem
            // 
            this.bassToolStripMenuItem.Name = "bassToolStripMenuItem";
            this.bassToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bassToolStripMenuItem.Text = "&Bass";
            this.bassToolStripMenuItem.Click += new System.EventHandler(this.bassToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(633, 551);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "             ";
            // 
            // txtTyping
            // 
            this.txtTyping.Enabled = false;
            this.txtTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyping.Location = new System.Drawing.Point(156, 296);
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.Size = new System.Drawing.Size(415, 80);
            this.txtTyping.TabIndex = 6;
            this.txtTyping.Visible = false;
            // 
            // nounsToolStripMenuItem
            // 
            this.nounsToolStripMenuItem.Name = "nounsToolStripMenuItem";
            this.nounsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.nounsToolStripMenuItem.Text = "Nouns";
            this.nounsToolStripMenuItem.Click += new System.EventHandler(this.nounsToolStripMenuItem_Click);
            // 
            // verbsToolStripMenuItem
            // 
            this.verbsToolStripMenuItem.Name = "verbsToolStripMenuItem";
            this.verbsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.verbsToolStripMenuItem.Text = "Verbs";
            this.verbsToolStripMenuItem.Click += new System.EventHandler(this.verbsToolStripMenuItem_Click);
            // 
            // adjutivesToolStripMenuItem
            // 
            this.adjutivesToolStripMenuItem.Name = "adjutivesToolStripMenuItem";
            this.adjutivesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.adjutivesToolStripMenuItem.Text = "Adjutives";
            this.adjutivesToolStripMenuItem.Click += new System.EventHandler(this.adjutivesToolStripMenuItem_Click);
            // 
            // prepositionsToolStripMenuItem
            // 
            this.prepositionsToolStripMenuItem.Name = "prepositionsToolStripMenuItem";
            this.prepositionsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.prepositionsToolStripMenuItem.Text = "Prepositions";
            this.prepositionsToolStripMenuItem.Click += new System.EventHandler(this.prepositionsToolStripMenuItem_Click);
            // 
            // mostCommonToolStripMenuItem
            // 
            this.mostCommonToolStripMenuItem.Name = "mostCommonToolStripMenuItem";
            this.mostCommonToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.mostCommonToolStripMenuItem.Text = "Most Common";
            this.mostCommonToolStripMenuItem.Click += new System.EventHandler(this.mostCommonToolStripMenuItem_Click);
            // 
            // FlashCardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 576);
            this.Controls.Add(this.txtTyping);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FlashCardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Flash Cards";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ColorTimer;
        private System.Windows.Forms.Label txtWord;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Timer SlowDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicalNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symbolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeSignatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator worldToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem level1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem level2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem level4ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem level5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem level6ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem level7ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem level8ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mathToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem countingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem additionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multiplcationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem level9ToolStripMenuItem;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolStripMenuItem typingToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTyping;
        private System.Windows.Forms.ToolStripMenuItem mostCommonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nounsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verbsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjutivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prepositionsToolStripMenuItem;
    }
}

