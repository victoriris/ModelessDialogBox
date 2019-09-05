using System;
using System.Windows.Forms;

namespace ModelessDialogBox
{
    public partial class ColorChooser : Form
    {
        public delegate void ChangeColorEvent(System.Drawing.Color color);
        public event ChangeColorEvent changeColor;

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

    }
}
