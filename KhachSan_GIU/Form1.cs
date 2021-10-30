using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan_GIU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var a = PointToScreen(label1.Location);
            a = panel1.PointToClient(a);
            label1.Parent = panel1;
            label1.Location = a;
            label1.BackColor = Color.Transparent;

            var b = PointToScreen(label2.Location);
            b = panel1.PointToClient(b);
            label2.Parent = panel1;
            label2.Location = b;
            label2.BackColor = Color.Transparent;

            //var c = PointToScreen(button1.Location);
            //c = panel1.PointToClient(c);
            //button1.Parent = panel1;
            //button1.Location = c;
            //button1.BackColor = Color.Transparent;

            var d = PointToScreen(pictureBox1.Location);
            d = panel1.PointToClient(d);
            pictureBox1.Parent = panel1;
            pictureBox1.Location = d;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.YesNo);
            if (t == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin t = new frmLogin();
            t.Show();
            this.Hide();
        }
    }
}
