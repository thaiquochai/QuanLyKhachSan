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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            dgvLoaiPhong.DataSource = LoaiPhong_BUS.GetLoaiPhong();
            dgvLoaiPhong.Columns[0].HeaderText = "Mã Loại Phòng";
            dgvLoaiPhong.Columns[0].Width = 120;
            dgvLoaiPhong.Columns[1].HeaderText = "Tên Loại Phòng";
            dgvLoaiPhong.Columns[1].Width = 120;
            dgvLoaiPhong.Columns[2].HeaderText = "Đơn giá";
            dgvLoaiPhong.Columns[2].Width = 80;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtmaLP.Text == "" || txtTenLP.Text == "" || txtDongia.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtmaLP.Text.Length > 20)
            {
                MessageBox.Show("Mã loại phòng tối đa 20 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (LoaiPhong_BUS.TimLoiaPhongTheoTen(txtmaLP.Text) != null)
            {
                MessageBox.Show("Mã loại phòng đã tồn tại!");
                return;
            }
            LoaiPhong_DTO kn = new LoaiPhong_DTO();
            kn.MaLphong = txtmaLP.Text;
            kn.TenLphong = txtTenLP.Text;
            kn.Dongia = double.Parse(txtDongia.Text);
            
            if (LoaiPhong_BUS.ThemLoaiPhong(kn) == true)
            {

                dgvLoaiPhong.DataSource = LoaiPhong_BUS.GetLoaiPhong();
                Reset();
                MessageBox.Show("Bạn Đã Thêm Thành Công...!!!");

            }
        }

        private void Reset()
        {
            txtmaLP.Text="";
            txtTenLP.Text = "";
            txtDongia.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtmaLP.Text == "" || txtTenLP.Text == "" || txtDongia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtmaLP.Text.Length > 20)
            {
                MessageBox.Show("Mã loại phòng tối đa 20 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (LoaiPhong_BUS.TimLoiaPhongTheoTen(txtmaLP.Text) == null)
            {
                MessageBox.Show("Mã loại phòng đã tồn tại!");
                return;
            }
            LoaiPhong_DTO kn = new LoaiPhong_DTO();
            kn.MaLphong = txtmaLP.Text;
            kn.TenLphong = txtTenLP.Text;
            kn.Dongia = double.Parse(txtDongia.Text);

            if (LoaiPhong_BUS.SuaLoaiPhong(kn) == true)
            {

                dgvLoaiPhong.DataSource = LoaiPhong_BUS.GetLoaiPhong();
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
                    LoaiPhong_DTO kn = new LoaiPhong_DTO();
                    kn.MaLphong = txtmaLP.Text;


                    if (LoaiPhong_BUS.XoaLoaiPhong(kn) == true)
                    {

                        dgvLoaiPhong.DataSource = LoaiPhong_BUS.GetLoaiPhong();
                        Reset();
                        MessageBox.Show("Bạn Đã Xóa Thành Công...!!!");

                    }
                }
            }
        }

        private void dgvLoaiPhong_Click(object sender, EventArgs e)
        {
            txtmaLP.Text = dgvLoaiPhong.CurrentRow.Cells[0].Value.ToString();
            txtTenLP.Text = dgvLoaiPhong.CurrentRow.Cells[1].Value.ToString();
            txtDongia.Text = dgvLoaiPhong.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
