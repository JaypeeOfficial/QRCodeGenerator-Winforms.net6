using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleQRCodeGenerator
{
    public partial class frmBarcode : Form
    {
        public frmBarcode()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                pictureBox1.Image = AppQRCoder.GetCode(textBox1.Text, chkWLogo.Checked);
            }
            else
            {
                MessageBox.Show(
                    "Please provide the code",
                    "No code",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }


        }
    }
}
