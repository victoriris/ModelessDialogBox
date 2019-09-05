using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelessDialogBox
{
    public partial class MainForm : Form
    {
        
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
            ColorChooser colorChooser = new ColorChooser();
            colorChooser.changeColor += bgColor_changed;

            if (isFormOpen("ColorChooser"))
            {
                colorChooser.BringToFront();
            } else
            {
                colorChooser.Show();
            }
            
        }
    }
}
