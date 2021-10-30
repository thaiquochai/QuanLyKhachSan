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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = HoaDon_BUS.GetHoaDon();
           // dgvHoaDon.DataSource = HoaDon_BUS.GetHDByDate(Convert.ToDateTime(dtNgaylap.Text));
            cbMakh.DataSource = KhachHang_BUS.GetKhachHangByTinhTrang();
            cbMakh.DisplayMember = "Makh";
            //cbMakh.ValueMember = "makh";
            //cbMaphong.DataSource = KhachHang_BUS.GetKH();
            //cbMaphong.DisplayMember = "Maphong";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaphong.DataSource = KhachHang_BUS.LoadMaPhongByMaKH(cbMakh.Text);
            cbMaphong.DisplayMember = "Maphong";
        }

        private void cbMaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNgaynhan.DataSource = KhachHang_BUS.LoadNgayByMaPhong(cbMaphong.Text);
            cbNgaynhan.DisplayMember = "Ngaynhan";
            cbNgaytra.DataSource = KhachHang_BUS.LoadNgayByMaPhong(cbMaphong.Text);
            cbNgaytra.DisplayMember = "Ngaytra";
            HoaDon_DTO t= new HoaDon_DTO();
           // t.Songaytro=int.Parse(txtSoNgay.Text);

            if (Convert.ToDateTime(cbNgaynhan.Text).Day > Convert.ToDateTime(cbNgaytra.Text).Day)
            {
                t.Songaytro = (Convert.ToDateTime(cbNgaytra.Text).Day + 30) - Convert.ToDateTime(cbNgaynhan.Text).Day;
                txtSoNgay.Text = (t.Songaytro).ToString();
            }
            else
            {
                t.Songaytro = (Convert.ToDateTime(cbNgaytra.Text).Day) - Convert.ToDateTime(cbNgaynhan.Text).Day;
                txtSoNgay.Text = (t.Songaytro).ToString();
            }
            cbTienphong.DataSource = LoaiPhong_BUS.LoadDonGiaByMaPhong(cbMaphong.Text);
            cbTienphong.DisplayMember = "Dongia";
            t.Thanhtien =(float) (t.Songaytro * double.Parse(cbTienphong.Text));
            txtThanhtien.Text = (t.Thanhtien).ToString();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn");
                return;
            }
            if (HoaDon_BUS.TimHDTheoTen(txtMaHD.Text) != null)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại");
                return;
            }
            if (HoaDon_BUS.TimHDTheoMaKH(cbMakh.Text) != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
                return;
            }
            if (HoaDon_BUS.TimHDTheoMaphong(cbMaphong.Text) != null && HoaDon_BUS.TimHDTheoNgay(Convert.ToDateTime(dtNgaylap.Text)) != null)
            {
                MessageBox.Show("Khách đã tính hóa đơn");
                return;
            }
            HoaDon_DTO t = new HoaDon_DTO();
            
            t.Mahd = txtMaHD.Text;
            t.Makh = cbMakh.Text;
            t.Ngaylap = Convert.ToDateTime(dtNgaylap.Text);
            t.Songaytro = int.Parse(txtSoNgay.Text);
            t.Tienphong = double.Parse(cbTienphong.Text);
            t.Thanhtien = double.Parse(txtThanhtien.Text);
            t.Maphong = cbMaphong.Text;
            if (HoaDon_BUS.ThemHD(t) == true)
            {
                dgvHoaDon.DataSource = HoaDon_BUS.GetHoaDon();
                MessageBox.Show("Bạn thêm thành công");
            }
            //t.Tienphong = double.Parse(cbTienphong.Text);

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn");
                return;
            }
            if (HoaDon_BUS.TimHDTheoTen(txtMaHD.Text) == null)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại");
                return;
            }
            if (HoaDon_BUS.TimHDTheoMaphong(cbMaphong.Text) != null && HoaDon_BUS.TimHDTheoNgay(Convert.ToDateTime(dtNgaylap.Text)) != null)
            {
                MessageBox.Show("Khách đã tính hóa đơn");
                return;
            }
            HoaDon_DTO t = new HoaDon_DTO();

            t.Mahd = txtMaHD.Text;
            t.Makh = cbMakh.Text;
            t.Ngaylap = Convert.ToDateTime(dtNgaylap.Text);
            t.Songaytro = int.Parse(txtSoNgay.Text);
            t.Tienphong = double.Parse(cbTienphong.Text);
            t.Thanhtien = double.Parse(txtThanhtien.Text);
            t.Maphong = cbMaphong.Text;
            if (HoaDon_BUS.SuaHD(t) == true)
            {
                dgvHoaDon.DataSource = HoaDon_BUS.GetHoaDon();
                MessageBox.Show("Bạn thêm thành công");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            HoaDon_DTO t = new HoaDon_DTO();

            t.Mahd = txtMaHD.Text;
            
            if (HoaDon_BUS.XoaHD(t) == true)
            {
                dgvHoaDon.DataSource = HoaDon_BUS.GetHoaDon();
                MessageBox.Show("Bạn Xóa thành công");
            }
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            cbMakh.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            dtNgaylap.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtSoNgay.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            cbTienphong.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();
            txtThanhtien.Text = dgvHoaDon.CurrentRow.Cells[5].Value.ToString();
            cbMaphong.Text = dgvHoaDon.CurrentRow.Cells[6].Value.ToString();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string ten = txttimkiem.Text;
            List<HoaDon_DTO> lstnv = HoaDon_BUS.TimHDTheoMaKH(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvHoaDon.DataSource = lstnv;
        }
    }
}
