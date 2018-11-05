using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Message in textbox will populate in message box.
            MessageBox.Show(txtMessage.Text,Convert.ToString(MessageBoxButtons.OK));
            txtMessage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the program
            this.Close();
        }
    }
}
