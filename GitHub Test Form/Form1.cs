using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub_Test_Form
{
    public partial class frmGitHub : Form
    {
        public frmGitHub()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void txtSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Number1 = Convert.ToDecimal(nudNumber1.Text);
            decimal Number2 = Convert.ToDecimal(nudNumber2.Text);
            decimal Sum = Number1 + Number2;

            txtSum.Text = Sum.ToString();
            txtSum.Focus();
        }

        private void nudNumber1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudNumber2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
