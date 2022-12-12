namespace Word_Flash_Cards
{
    partial class ShapesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapesForm));
            this.btnShape = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblShapeName = new System.Windows.Forms.Label();
            this.shapesImageList = new System.Windows.Forms.ImageList(this.components);
            this.shapePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.shapePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShape
            // 
            this.btnShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShape.Location = new System.Drawing.Point(261, 457);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(166, 68);
            this.btnShape.TabIndex = 1;
            this.btnShape.Text = "New Shape";
            this.btnShape.UseVisualStyleBackColor = true;
            this.btnShape.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // lblShapeName
            // 
            this.lblShapeName.AutoSize = true;
            this.lblShapeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShapeName.Location = new System.Drawing.Point(291, 387);
            this.lblShapeName.Name = "lblShapeName";
            this.lblShapeName.Size = new System.Drawing.Size(112, 31);
            this.lblShapeName.TabIndex = 2;
            this.lblShapeName.Text = "              ";
            // 
            // shapesImageList
            // 
            this.shapesImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("shapesImageList.ImageStream")));
            this.shapesImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.shapesImageList.Images.SetKeyName(0, "4 pointed Star.bmp");
            this.shapesImageList.Images.SetKeyName(1, "5 pointed Star.bmp");
            this.shapesImageList.Images.SetKeyName(2, "6 pointed Star.bmp");
            this.shapesImageList.Images.SetKeyName(3, "Diamond.bmp");
            this.shapesImageList.Images.SetKeyName(4, "Down Arrow.bmp");
            this.shapesImageList.Images.SetKeyName(5, "Heart.bmp");
            this.shapesImageList.Images.SetKeyName(6, "Hexagon.bmp");
            this.shapesImageList.Images.SetKeyName(7, "Left Arrow.bmp");
            this.shapesImageList.Images.SetKeyName(8, "Pentagon.bmp");
            this.shapesImageList.Images.SetKeyName(9, "Rectangle.bmp");
            this.shapesImageList.Images.SetKeyName(10, "Right Arrow.bmp");
            this.shapesImageList.Images.SetKeyName(11, "Right Triangle.bmp");
            this.shapesImageList.Images.SetKeyName(12, "Thunder bolt.bmp");
            this.shapesImageList.Images.SetKeyName(13, "Triangle.bmp");
            this.shapesImageList.Images.SetKeyName(14, "UP Arrow.bmp");
            // 
            // shapePicBox
            // 
            this.shapePicBox.Location = new System.Drawing.Point(111, 53);
            this.shapePicBox.Name = "shapePicBox";
            this.shapePicBox.Size = new System.Drawing.Size(452, 299);
            this.shapePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shapePicBox.TabIndex = 0;
            this.shapePicBox.TabStop = false;
            // 
            // ShapesForm
            // 
            this.AcceptButton = this.btnShape;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 576);
            this.Controls.Add(this.lblShapeName);
            this.Controls.Add(this.btnShape);
            this.Controls.Add(this.shapePicBox);
            this.Name = "ShapesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shapes";
            ((System.ComponentModel.ISupportInitialize)(this.shapePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShape;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblShapeName;
        private System.Windows.Forms.ImageList shapesImageList;
        private System.Windows.Forms.PictureBox shapePicBox;
    }
}