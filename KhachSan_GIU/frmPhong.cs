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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = Phong_BUS.GetPhong();
            cbMaLP.DataSource = LoaiPhong_BUS.GetLoaiPhong();
            cbMaLP.DisplayMember = "TenLphong";
            cbMaLP.ValueMember = "maLphong";
            dgvPhong.Columns[0].HeaderText = "Mã phòng";
            dgvPhong.Columns[0].Width = 100;
            dgvPhong.Columns[1].HeaderText = "Tên phòng";
            dgvPhong.Columns[1].Width = 100;
            dgvPhong.Columns[2].HeaderText = "Tinh trạng";
            dgvPhong.Columns[2].Width = 80;
            dgvPhong.Columns[3].HeaderText = "Mã loại phòng";
            dgvPhong.Columns[3].Width = 100;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtmaphong.Text == "" || txtTenPhong.Text == "" || txtTinhtrang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtmaphong.Text.Length > 20)
            {
                MessageBox.Show("Mã phòng tối đa 20 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (Phong_BUS.TimPhongTheoTen(txtmaphong.Text) != null)
            {
                MessageBox.Show("Mã phòng đã tồn tại!");
                return;
            }
            Phong_DTO kn = new Phong_DTO();
            kn.Maphong = txtmaphong.Text;
            kn.Tenphong = txtTenPhong.Text;
            kn.Tinhtrang = txtTinhtrang.Text;
            kn.MaLphong = cbMaLP.SelectedValue.ToString();
            if (Phong_BUS.ThemPhong(kn) == true)
            {

                dgvPhong.DataSource = Phong_BUS.GetPhong();
                Reset();
                MessageBox.Show("Bạn Đã Thêm Thành Công...!!!");

            }
        }

        private void Reset()
        {
            txtmaphong.Text = "";
            txtTenPhong.Text = "";
            txtTinhtrang.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtmaphong.Text == "" || txtTenPhong.Text == "" || txtTinhtrang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtmaphong.Text.Length > 20)
            {
                MessageBox.Show("Mã phòng tối đa 20 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (Phong_BUS.TimPhongTheoTen(txtmaphong.Text) == null)
            {
                MessageBox.Show("Mã phòng đã tồn tại!");
                return;
            }
            Phong_DTO kn = new Phong_DTO();
            kn.Maphong = txtmaphong.Text;
            kn.Tenphong = txtTenPhong.Text;
            kn.Tinhtrang = txtTinhtrang.Text;
            kn.MaLphong = cbMaLP.SelectedValue.ToString();
            if (Phong_BUS.SuaPhong(kn) == true)
            {

                dgvPhong.DataSource = Phong_BUS.GetPhong();
                Reset();
                MessageBox.Show("Bạn Đã Sửa Thành Công...!!!");

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Xóa Không ?", "Thông Báo...!!!", MessageBoxButtons.OKCancel);
            {
                if (tb == DialogResult.OK)
                {
                    Phong_DTO kn = new Phong_DTO();
                    kn.Maphong = txtmaphong.Text;

                    if (Phong_BUS.XoaPhong(kn) == true)
                    {

                        dgvPhong.DataSource = Phong_BUS.GetPhong();
                        Reset();
                        MessageBox.Show("Bạn Đã Xóa Thành Công...!!!");

                    }
                }
            }
        }

        private void dgvPhong_Click(object sender, EventArgs e)
        {
            txtmaphong.Text = dgvPhong.CurrentRow.Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhong.CurrentRow.Cells[1].Value.ToString();
            txtTinhtrang.Text = dgvPhong.CurrentRow.Cells[2].Value.ToString();
            cbMaLP.SelectedValue = dgvPhong.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
