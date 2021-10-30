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
    public partial class frmDoiMatKhau : Form
    {
        string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTen.Text = Ten;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TaiKhoan_DTO tk = TaiKhoan_BUS.GetAccount(txtTen.Text, txtPasscu.Text);
            MD5 t = MD5.Create();
            string mk = TaiKhoan_BUS.GetMd5Hash(t, txtPasscu.Text);
            if (txtPasscu.Text == "" || txtPassMoi.Text == "" || txtNhaplaiPass.Text == "")
            {
                MessageBox.Show("Không được bỏ trống");
                return;
            }
            if (string.Compare(tk.Matkhau,mk)!=0)
            {
                MessageBox.Show("Vui lòng nhập đúng mật khẩu");
                return;
            }
            if (string.Compare(txtPassMoi.Text, txtNhaplaiPass.Text) != 0)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
                return;
            }
            TaiKhoan_DTO ts = new TaiKhoan_DTO();
            string mkm = TaiKhoan_BUS.GetMd5Hash(t, txtPassMoi.Text);
            ts.Tentk=txtTen.Text;
            ts.Matkhau=mkm;
            if (TaiKhoan_BUS.SuaPass(ts) == true)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
            }
            
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
