using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay
{
    private void btnthoat_click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void btnDangnhap_click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(chuoikn);
        string sqlSelect = "Select * from tblTaikhoan where Taikhoan=" + txtTaikhoan.Text + "and Matkhaau=" + txtMatkhau.Text+"
        conn.Open();
        SQLCommand cmd = new SQLCommand(sqlSelect, conn);
        SqlDataReader reader = cmd.ExecuteReader();
        if(reader.Read()==true)
        {
            this.Hide();
            frmMain = new frmMain();
            Main.Show();

        }
        else
        {
            MessageBox.Show("ban dang nhap không thành công");
            txtTaikhoan.Text = "";
            txtMatkhau.text = "";
            txtTaikhoan.Focus();
        }
    }
}
