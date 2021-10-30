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

namespace KhachSan_GIU
{
    public partial class frm_bcHoaDon : Form
    {
        public frm_bcHoaDon()
        {
            InitializeComponent();
           
        }

        private void frm_bcHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyKSDataSet.hoadon' table. You can move, or remove it, as needed.
            //this.hoadonTableAdapter.Fill(this.QuanLyKSDataSet.hoadon);
            this.hoadonBindingSource.DataSource = HoaDon_BUS.GetHoaDon();
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
