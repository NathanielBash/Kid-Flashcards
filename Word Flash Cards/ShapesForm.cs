using System;
using System.Windows.Forms;

namespace Word_Flash_Cards
{
    public partial class ShapesForm : Form
    {
        public ShapesForm()
        {
            InitializeComponent();
            btnShape.Focus();
        }

        private void btnShape_Click(object sender, EventArgs e)
        {
            Random randShape = new Random();

            int index = randShape.Next();
            shapePicBox.Image = shapesImageList.Images[index];

            //lblShapeName.Text = shapePicBox.Image.Tag.ToString();
        }
    }
}
