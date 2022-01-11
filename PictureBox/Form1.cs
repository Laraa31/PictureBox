using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void btnSakrij_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
