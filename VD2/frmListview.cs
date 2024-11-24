using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VD2
{
    public partial class frmListview : Form
    {
        public frmListview()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvNhanVien.SelectedItems)
                {
                    lvNhanVien.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            //tao dong du lieu(Listviewitem)
            ListViewItem lv = new ListViewItem(txtLastName.Text);
            //them cac cot con lai
            lv.SubItems.Add(txtFirstName.Text);
            lv.SubItems.Add(txtPhone.Text);
            lvNhanVien.Items.Add(lv);
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lvNhanVien.SelectedItems[0];

              
                selectedItem.SubItems[0].Text = txtLastName.Text;
                selectedItem.SubItems[1].Text = txtFirstName.Text;
                selectedItem.SubItems[2].Text = txtPhone.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count == 1)
            {
                
                ListViewItem selectedItem = lvNhanVien.SelectedItems[0];

                
                txtLastName.Text = selectedItem.SubItems[0].Text; 
                txtFirstName.Text = selectedItem.SubItems[1].Text; 
                txtPhone.Text = selectedItem.SubItems[2].Text; 
            }
            else
            {
               
                txtLastName.Text = string.Empty;
                txtFirstName.Text = string.Empty;
                txtPhone.Text = string.Empty;
            }
        }
    }
}
