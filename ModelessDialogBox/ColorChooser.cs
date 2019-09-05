using System;
using System.Windows.Forms;

namespace ModelessDialogBox
{
    public partial class ColorChooser : Form
    {
        public delegate void ChangeColorEvent(System.Drawing.Color color);
        public event ChangeColorEvent changeColor;
        public string selectedColor = "";

        public ColorChooser()
        {
            InitializeComponent();
        }


        private void RadioBtn_changed(object sender, EventArgs e)
        {
            RadioButton currentBox = (RadioButton) sender;
            changeColor(System.Drawing.Color.FromName(currentBox.Text));
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OtherBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
               changeColor(colorDialog.Color);
            }
        }

        private void ColorChooser_Load(object sender, EventArgs e)
        {
            bool optionFound = false;
            foreach (RadioButton colorBtn in colorsPanel.Controls)
            {
                if (colorBtn.Text == selectedColor)
                {
                    colorBtn.Checked = true;
                    optionFound = true;
                }
            }
            if (!optionFound && selectedColor.Length > 0)
            {
                otherBtn.Checked = true;
            }
        }
    }
}
