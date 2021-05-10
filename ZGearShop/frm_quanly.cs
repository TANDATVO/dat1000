using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZGearShop
{
    public partial class frm_quanly : Form
    {
        public frm_quanly()
        {
            InitializeComponent();
        }

        private void quảnLýNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            frm_nhanvien fnv = new frm_nhanvien();
            fnv.Show();
        }

        private void btn_qlsp_Click(object sender, EventArgs e)
        {
            frm_qlsanpham fsp = new frm_qlsanpham();
            fsp.Show();
        }
    }
}
