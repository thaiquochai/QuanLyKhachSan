using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
namespace KhachSan_GIU
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        string mp;

        public string Mp
        {
            get { return mp; }
            set { mp = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = KhachHang_BUS.GetKH();
            cbMaphong.DataSource = Phong_BUS.GetPhong();
            cbMaphong.DisplayMember = "Maphong";
            cbMaphong.ValueMember = "maphong";

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtManv.Text == "" || txtHoten.Text == "" || txtdienthoai.Text == "" || txtdiachi.Text == "" || txtcmnd.Text == "" || txtQuoctich.Text == "")
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
            if (KhachHang_BUS.TimKHTheoTen(txtManv.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            if (KhachHang_BUS.TimKHTheoNgaDat(Convert.ToDateTime(dtNgaydat.Text)) != null && KhachHang_BUS.TimKHTheoMaphong(cbMaphong.Text) != null)
            {
                MessageBox.Show("Phòng đã có người đặt!");
                return;
            }
            KhachHang_DTO kn = new KhachHang_DTO();
            Phong_DTO t = new Phong_DTO();
            kn.Makh = txtManv.Text;
            kn.Tenkh = txtHoten.Text;
            if (DateTime.Parse(dtNgaySinh.Text).Year > 2000)
            {
                MessageBox.Show("Năm sinh phải nhỏ hơn năm 2000!");
                return;
            }
            else
            {
                kn.Ngaysinhkh = DateTime.Parse(dtNgaySinh.Text);
            }
            if (radnam.Checked)
            {
                kn.Gioitinhkh = "Nam";
            }
            else if (radnu.Checked)
            {
                kn.Gioitinhkh = "Nữ";
            }
            kn.Diachikh = txtdiachi.Text;
            kn.Sdtkh = txtdienthoai.Text;
            kn.Cmnd = txtcmnd.Text;
            kn.Quoctich = txtQuoctich.Text;
            if (DateTime.Parse(dtNgaydat.Text).Year < DateTime.Parse(dtNgaySinh.Text).Year)
            {
                MessageBox.Show("Ngày đặt phải lớn hơn ngày sinh");
                return;
            }
            else
            {
                kn.Ngaydangky = DateTime.Parse(dtNgaydat.Text);
            }

            if (DateTime.Parse(dtNgayNhan.Text) < DateTime.Parse(dtNgaydat.Text))
            {
                MessageBox.Show("Ngày nhận phải lớn hơn hoặc bằng ngày đặt");
                return;
            }
            else
            {
                kn.Ngaynhan = DateTime.Parse(dtNgayNhan.Text);
            }
            if (DateTime.Parse(dtNgayTra.Text) < DateTime.Parse(dtNgayNhan.Text))
            {
                MessageBox.Show("Ngày trả phải lớn hơn ngày nhận");
                return;
            }
            else
            {
                kn.Ngaytra = DateTime.Parse(dtNgayTra.Text);
            }
            kn.Maphong = cbMaphong.SelectedValue.ToString();

            kn.Tinhtrang = cbTinhtrang.Text;
            if (KhachHang_BUS.ThemKH(kn) == true)
            {

                dgvKhachHang.DataSource = KhachHang_BUS.GetKH();
                Reset();
                MessageBox.Show("Bạn Đã Thêm Thành Công...!!!");

            }
            else
            { MessageBox.Show("Không thêm đưươ"); }
        }

        private void Reset()
        {
            txtManv.Text = "";
            txtHoten.Text = "";
            txtdienthoai.Text = "";
            txtdiachi.Text = "";
            txtcmnd.Text = "";
            txtQuoctich.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "" || txtHoten.Text == "" || txtdienthoai.Text == "" || txtdiachi.Text == "" || txtcmnd.Text == "" || txtQuoctich.Text == "")
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
            if (KhachHang_BUS.TimKHTheoTen(txtManv.Text) == null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            KhachHang_DTO kn = new KhachHang_DTO();
            kn.Makh = txtManv.Text;
            kn.Tenkh = txtHoten.Text;
            if (Convert.ToDateTime(dtNgaySinh.Text).Year > 2000)
            {
                MessageBox.Show("Năm sinh phải nhỏ hơn năm 2000!");
                return;
            }
            else
            {
                kn.Ngaysinhkh = Convert.ToDateTime(dtNgaySinh.Text);
            }
            if (radnam.Checked)
            {
                kn.Gioitinhkh = "Nam";
            }
            else if (radnu.Checked)
            {
                kn.Gioitinhkh = "Nữ";
            }
            kn.Diachikh = txtdiachi.Text;
            kn.Sdtkh = txtdienthoai.Text;
            kn.Cmnd = txtcmnd.Text;
            kn.Quoctich = txtQuoctich.Text;
            if (Convert.ToDateTime(dtNgaydat.Text).Year < Convert.ToDateTime(dtNgaySinh.Text).Year)
            {
                MessageBox.Show("Ngày đặt phải lớn hơn ngày sinh");
                return;
            }
            else
            {
                kn.Ngaydangky = Convert.ToDateTime(dtNgaydat.Text);
            }
            if (Convert.ToDateTime(dtNgayNhan.Text) < Convert.ToDateTime(dtNgaydat.Text))
            {
                MessageBox.Show("Ngày nhận phải lớn hơn ngày đặt");
                return;
            }
            else
            {
                kn.Ngaynhan = Convert.ToDateTime(dtNgayNhan.Text);
            }
            if (Convert.ToDateTime(dtNgayTra.Text) <= Convert.ToDateTime(dtNgayNhan.Text))
            {
                MessageBox.Show("Ngày trả phải lớn hơn ngày nhận");
                return;
            }
            else
            {
                kn.Ngaytra = Convert.ToDateTime(dtNgayTra.Text);
            }
            kn.Maphong = cbMaphong.SelectedValue.ToString();
            kn.Tinhtrang = cbTinhtrang.Text;
            if (KhachHang_BUS.SuaKH(kn) == true)
            {

                dgvKhachHang.DataSource = KhachHang_BUS.GetKH();
                Reset();
                MessageBox.Show("Bạn Đã Sửa Thành Công...!!!");

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Xóa Không ?", "Thông Báo...!!!", MessageBoxButtons.OKCancel);
            {
                if (tb == DialogResult.OK)
                {
                    KhachHang_DTO kn = new KhachHang_DTO();
                    kn.Makh = txtManv.Text;

                    if (KhachHang_BUS.XoaKH(kn) == true)
                    {

                        dgvKhachHang.DataSource = KhachHang_BUS.GetKH();
                        Reset();
                        MessageBox.Show("Bạn Đã Xóa Thành Công...!!!");

                    }
                }
            }
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            txtManv.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            if (dgvKhachHang.CurrentRow.Cells[3].Value.ToString() == "Nam")
            {
                radnam.Checked = true;
            }
            else if (dgvKhachHang.CurrentRow.Cells[3].Value.ToString() == "Nữ")
            {
                radnu.Checked = true;
            }
            txtdiachi.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtdienthoai.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
            txtcmnd.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
            txtQuoctich.Text = dgvKhachHang.CurrentRow.Cells[7].Value.ToString();
            dtNgaydat.Text = dgvKhachHang.CurrentRow.Cells[8].Value.ToString();
            dtNgayNhan.Text = dgvKhachHang.CurrentRow.Cells[9].Value.ToString();
            dtNgayTra.Text = dgvKhachHang.CurrentRow.Cells[10].Value.ToString();
            cbMaphong.SelectedValue = dgvKhachHang.CurrentRow.Cells[11].Value.ToString();
            cbTinhtrang.Text = dgvKhachHang.CurrentRow.Cells[12].Value.ToString();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string ten = txttimkiem.Text;
            List<KhachHang_DTO> lstnv = KhachHang_BUS.TimKHTheoName(ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvKhachHang.DataSource = lstnv;
            Reset();

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            //string ten = txttimkiem.Text;
            //List<KhachHang_DTO> lstnv = KhachHang_BUS.TimKHTheoName(ten);
            //if (lstnv == null)
            //{
            //    MessageBox.Show("Không tìm thấy!");
            //    return;
            //}
            //dgvKhachHang.DataSource = lstnv;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbmanv_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dtNgaydat_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
