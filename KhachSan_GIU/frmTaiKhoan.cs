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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = TaiKhoan_BUS.DSTaiKhoan();
            cbManv.DataSource  = NhanVien_BUS.GetNhanVien();
            cbManv.DisplayMember = "Tennv";
            cbManv.ValueMember = "manv";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txttentk.Text == "" || txtMatKhau.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txttentk.Text.Length > 20)
            {
                MessageBox.Show("Tên tài khoản tối đa 20 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (TaiKhoan_BUS.TimTheoTen(txttentk.Text) != null)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
                return;
            }
            MD5 t = MD5.Create();
            string a = TaiKhoan_BUS.GetMd5Hash(t, txtMatKhau.Text);
            TaiKhoan_DTO kn = new TaiKhoan_DTO();
            kn.Tentk = txttentk.Text;
            kn.Matkhau = a;
            kn.Quyen = int.Parse(nudQuyen.Text);
            kn.Manv = cbManv.SelectedValue.ToString();
            if (TaiKhoan_BUS.ThemTaiKhoan(kn) == true)
            {

                dgvTaiKhoan.DataSource = TaiKhoan_BUS.DSTaiKhoan();
                Reset();
                MessageBox.Show("Bạn Đã Thêm Thành Công...!!!");

            }
        }

        private void Reset()
        {
            txttentk.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txttentk.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txttentk.Text.Length > 20)
            {
                MessageBox.Show("Tên tài khoản tối đa 20 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (TaiKhoan_BUS.TimTheoTen(txttentk.Text) == null)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
                return;
            }
            MD5 t = MD5.Create();
            string a = TaiKhoan_BUS.GetMd5Hash(t, txtMatKhau.Text);
            TaiKhoan_DTO kn = new TaiKhoan_DTO();
            kn.Tentk = txttentk.Text;
            kn.Matkhau = a;
            kn.Quyen = int.Parse(nudQuyen.Text);
            kn.Manv = cbManv.SelectedValue.ToString();
            if (TaiKhoan_BUS.SuaTaiKhoan(kn) == true)
            {

                dgvTaiKhoan.DataSource = TaiKhoan_BUS.DSTaiKhoan();
                Reset();
                MessageBox.Show("Bạn Đã Sửa Thành Công...!!!");

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            TaiKhoan_DTO kn = new TaiKhoan_DTO();
            kn.Tentk = txttentk.Text;
            
            if (TaiKhoan_BUS.XoaTK(kn) == true)
            {

                dgvTaiKhoan.DataSource = TaiKhoan_BUS.DSTaiKhoan();
                Reset();
                MessageBox.Show("Bạn Đã Xóa Thành Công...!!!");

            }
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            txttentk.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            nudQuyen.Value =decimal.Parse( dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString());
            cbManv.SelectedValue = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
