using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       private void btnHo_Click(object sender, EventArgs e)
       {
            lblHoTen.Text = "Họ và tên: " + txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = "Họ và tên: " + txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = "Họ và tên: " + txtHo.Text +" "+ txtTen.Text;
       }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
