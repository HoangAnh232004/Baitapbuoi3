using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VD2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnXuatthongtin_Click(object sender, EventArgs e)
        {
            //btnXuatthongtin.Click += (sender, e) =>
            //{
            //    // Lấy thông tin Họ và Tên
            //    string hoten = txtHoTen.Text.Trim();

            //    // Lấy thông tin Ngày Sinh
            //    string ngaySinh = dtbNgaySinh.Value.ToShortDateString();

            //    // Lấy thông tin Giới Tính
            //    string gioiTinh = rbtnGioiTinh.Checked ? "Nam" : rbtnGioiTinh2.Checked ? "Nữ" : "Không xác định";

            //    // Lấy thông tin Sở Thích
            //    string soThich = string.Join(", ", cbSoThich1.CheckedItems.Cast<string>());

            //    // Kiểm tra thông tin
            //    if (string.IsNullOrWhiteSpace(ho) || string.IsNullOrWhiteSpace(ten))
            //    {
            //        MessageBox.Show("Vui lòng nhập đầy đủ Họ và Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // Xuất thông tin ra MessageBox
            //    string message = $"Họ và Tên: {ho} {ten}\n" +
            //                     $"Ngày Sinh: {ngaySinh}\n" +
            //                     $"Giới Tính: {gioiTinh}\n" +
            //                     $"Sở Thích: {(string.IsNullOrEmpty(soThich) ? "Không có" : soThich)}";

            //    MessageBox.Show(message, "Thông Tin Người Dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //};

            //// Thêm các điều khiển vào Form
            //this.Controls.Add(txtHoTen);
            
            //this.Controls.Add(dtbNgaySinh);
            //this.Controls.Add(lblGioitinh);
            //this.Controls.Add(rbtnGioiTinh);
            //this.Controls.Add(rbtnGioiTinh2);
            //this.Controls.Add(lblSoThich);
            //this.Controls.Add(cbSoThich1);
            //this.Controls.Add(cbSoThich2);
            //this.Controls.Add(cbSoThich3);
            //this.Controls.Add(btnXuatthongtin);
            String ten = txtHoTen.Text;
            String NgaySinh=dtbNgaySinh.Text;
            String GioiTinh = rbtnGioiTinh.Checked ? "Nam" : "Nu";
            String st = (cbSoThich1.Checked ?
                cbSoThich2.Text : "") + (cbSoThich3.Checked ?
                ", " + cbSoThich2.Text : "")
                + (cbSoThich3.Checked ?
                ", " + cbSoThich3.Text : "");
            MessageBox.Show("Họ tên : " +
                ten
                + ", Giới tính : " + GioiTinh
                + ", Ngày sinh : " + NgaySinh
                + ", Sở thích : " + st);

        }
    }
}
