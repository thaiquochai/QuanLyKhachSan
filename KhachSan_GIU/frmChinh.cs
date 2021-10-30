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
namespace KhachSan_GIU
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            var a = PointToScreen(label1.Location);
            a = panel1.PointToClient(a);
            label1.Parent = panel1;
            label1.Location = a;
            label1.BackColor = Color.Transparent;
            LoadPhong();

            if (frmChinh.lv > 1 )
            {
                thôngTinTàiKhoảnToolStripMenuItem.Text = "Nhân viên "+"("+frmChinh.Ten+")";

            }
            else
            {
                thôngTinTàiKhoảnToolStripMenuItem.Text = "Admin " + "(" + frmChinh.Ten + ")";
            }
            if (frmChinh.lv > 1)
            {
                mnNhanVien.Visible = false;
                mnTaiKhoan.Visible = false;
                mnLoaiPhong.Visible = false;
                mnPhong.Visible = false;
                mndulieu.Visible = false;

            }
           
           
        }
        static frmChinh frm;
        public static int lv;
        public static string manv;
        public static string Ten;
        public static frmChinh Frm
        {
            get { if (frm == null || frm.IsDisposed) frm = new frmChinh(); return frmChinh.frm; }
            set { frmChinh.frm = value; }
        }
        public void LoadPhong()
        {
            flpPhong.Controls.Clear();

            List<Phong_DTO> tableList = Phong_BUS.GetPhong();

            foreach (Phong_DTO item in tableList)
            {
                Button btn = new Button() { Width = Phong_BUS.TableWidth, Height = Phong_BUS.TableHeight };
                if( item.MaLphong=="T1")
                {
                    item.MaLphong="Thường đơn";
                }
                else if( item.MaLphong=="T2")
                {
                    item.MaLphong="Thường đôi";
                }
                else if( item.MaLphong=="V1")
                {
                    item.MaLphong="VIP đơn";
                }
                else if( item.MaLphong=="V2")
                {
                    item.MaLphong="VIP đôi";
                }
                btn.Text = item.Tenphong + Environment.NewLine + item.Tinhtrang  + Environment.NewLine + item.MaLphong
                ;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Tinhtrang)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        //btn.BackgroundImage = global::GUI_KS.Properties.Resources.home;
                        break;
                    case "Đã đặt":
                        btn.BackColor = Color.Red;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpPhong.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            frmKhachHang t = new frmKhachHang();
           // t.Mp=
            t.ShowDialog();
        }
        private void mnLoaiPhong_Click(object sender, EventArgs e)
        {
            frmLoaiPhong t = new frmLoaiPhong();
            this.Hide();
            t.ShowDialog();
            this.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn đóng đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void mnPhong_Click(object sender, EventArgs e)
        {
            frmPhong t = new frmPhong();
            this.Hide();
            t.ShowDialog();
            this.Show();
            LoadPhong();
        }

        private void mnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang t = new frmKhachHang();
            this.Hide();
            t.ShowDialog();
            this.Show();
            LoadPhong();
        }

        private void mnNhanVien_Click(object sender, EventArgs e)
        {
            if (frmChinh.lv > 1)
            {
                MessageBox.Show("Tài khoản không có quyền sử dụng menu " + mnNhanVien.Text, "Thông báo");
                return;
            }
            frmNhanVien t = new frmNhanVien();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private void mnTaiKhoan_Click(object sender, EventArgs e)
        {
            if (frmChinh.lv > 1)
            {
                MessageBox.Show("Tài khoản không có quyền sử dụng menu " + mnTaiKhoan.Text, "Thông báo");
                return;
            }
            else
            {
                frmTaiKhoan t = new frmTaiKhoan();
                this.Hide();
                t.ShowDialog();
                this.Show();
            }
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            
        }

        private void mnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin t = new frmLogin();
            t.Visible = true;
        }

        private void mnUpdateTaiKhoan_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau t = new frmDoiMatKhau();
            t.Ten = frmChinh.Ten;
            this.Hide();
            t.ShowDialog();
            this.Show();
            
        }

        private void mnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon t = new frmHoaDon();
            
            this.Hide();
            t.ShowDialog();
            this.Show();
            LoadPhong();
        }

        private void mnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            frm_bcHoaDon t = new frm_bcHoaDon();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,System.IO.Path.Combine(Application.StartupPath,"fHelp.chm"));
        }

        private void mnsaolu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void mnkhoiphuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK &&
            phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }
    }
}
