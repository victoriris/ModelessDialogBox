using System;
using System.Windows.Forms;

namespace ModelessDialogBox
{
    public partial class MainForm : Form
    {

        ColorChooser colorChooser;

        public MainForm()
        {
            InitializeComponent();
        }


        private void bgColor_changed(System.Drawing.Color color)
        {
            this.BackColor = color;
        }

        private bool isFormOpen(string formName)
        {
            FormCollection openForms = Application.OpenForms;
            foreach (Form f in openForms)
            {
                //iterate through
                if (f.Name == formName)
                {
                    return true;
                }
            }

            return false;
        }

        private void ColorChangeBtn_Click(object sender, EventArgs e)
        {
            colorChooser = new ColorChooser();
            colorChooser.changeColor += bgColor_changed;

            colorChooser.selectedColor = this.BackColor.Name;
            colorChooser.TopMost = true;

            if (!isFormOpen("ColorChooser"))
            {
                colorChooser.Show();
            }        

        }
    }
}
