using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Security.Cryptography;
namespace KhachSan_GIU
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn đóng đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Chưa Nhập Password or User");
                return;
            }

            TaiKhoan_DTO acc = TaiKhoan_BUS.GetAccount(txtusername.Text, txtpassword.Text);
            MD5 t = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.GetMd5Hash(t, txtpassword.Text);
            if (string.Compare(acc.Tentk, txtusername.Text) != 0)
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng");
                return;
            }
            
            if (string.Compare(acc.Matkhau, matkhauMH) != 0)
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu");
                return;
            }
            frmChinh.Ten = acc.Tentk;
            frmChinh.lv = acc.Quyen;
            frmChinh.manv = acc.Manv;
            frmChinh.Frm.Show();
            txtpassword.Text = "";
            txtusername.Text = "";

            txtusername.Focus();
            this.Visible = false;
            
            Form1 a = new Form1();
            a.Close();
            
            
        }
    }
}
