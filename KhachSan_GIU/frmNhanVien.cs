using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace KhachSan_GIU
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVien_BUS.GetNhanVien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtManv.Text == "" || txtHoten.Text == "" || txtdienthoai.Text == "" || txtdiachi.Text == "" || txtemail.Text == "" || txtchucvu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtManv.Text.Length > 20)
            {
                MessageBox.Show("Mã nhân viên tối đa 20 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNVTheoTen(txtManv.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            NhanVien_DTO kn = new NhanVien_DTO();
            
            kn.Manv = txtManv.Text;
            kn.Tennv = txtHoten.Text;
            if (Convert.ToDateTime(dtNgaySinh.Text).Year > 2000)
            {
                MessageBox.Show("Năm sinh phải nhỏ hơn năm 2000!");
                return;
            }
            else
            {
                kn.Ngaysinhnv = Convert.ToDateTime(dtNgaySinh.Text);
            }
            if (radnam.Checked)
            {
                kn.Gioitinhnv = "Nam";
            }
            else if (radnu.Checked)
            {
                kn.Gioitinhnv = "Nữ";
            }
            kn.Diachinv = txtdiachi.Text;
            kn.Sdtnv = txtdienthoai.Text;
            kn.Email = txtemail.Text;
            kn.Chucvu = txtchucvu.Text;
            
            if (NhanVien_BUS.ThemNV(kn) == true)
            {

                dgvNhanVien.DataSource = NhanVien_BUS.GetNhanVien();
                Reset();
                MessageBox.Show("Bạn Đã Thêm Thành Công...!!!");

            }
        }

        private void Reset()
        {
            txtManv.Text = "";
            txtHoten.Text = "";
            txtdienthoai.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            txtchucvu.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtManv.Text == "" || txtHoten.Text == "" || txtdienthoai.Text == "" || txtdiachi.Text == "" || txtemail.Text == "" || txtchucvu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtManv.Text.Length > 20)
            {
                MessageBox.Show("Mã nhân viên tối đa 20 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNVTheoTen(txtManv.Text) == null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            NhanVien_DTO kn = new NhanVien_DTO();

            kn.Manv = txtManv.Text;
            kn.Tennv = txtHoten.Text;
            if (Convert.ToDateTime(dtNgaySinh.Text).Year > 2000)
            {
                MessageBox.Show("Năm sinh phải nhỏ hơn năm 2000!");
                return;
            }
            else
            {
                kn.Ngaysinhnv = Convert.ToDateTime(dtNgaySinh.Text);
            }
            if (radnam.Checked)
            {
                kn.Gioitinhnv = "Nam";
            }
            else if (radnu.Checked)
            {
                kn.Gioitinhnv = "Nữ";
            }
            kn.Diachinv = txtdiachi.Text;
            kn.Sdtnv = txtdienthoai.Text;
            kn.Email = txtemail.Text;
            kn.Chucvu = txtchucvu.Text;

            if (NhanVien_BUS.SuaNV(kn) == true)
            {

                dgvNhanVien.DataSource = NhanVien_BUS.GetNhanVien();
                Reset();
                MessageBox.Show("Bạn Đã Sửa Thành Công...!!!");

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
           
            NhanVien_DTO kn = new NhanVien_DTO();

            kn.Manv = txtManv.Text;
            
            if (NhanVien_BUS.XoaNV(kn) == true)
            {

                dgvNhanVien.DataSource = NhanVien_BUS.GetNhanVien();
                Reset();
                MessageBox.Show("Bạn Đã Xóa Thành Công...!!!");

            }
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            txtManv.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            if (dgvNhanVien.CurrentRow.Cells[3].Value.ToString() == "Nam")
            {
                radnam.Checked = true;
            }
            else if (dgvNhanVien.CurrentRow.Cells[3].Value.ToString() == "Nữ")
            {
                radnu.Checked = true;
            }
            txtdiachi.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtdienthoai.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtemail.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtchucvu.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
