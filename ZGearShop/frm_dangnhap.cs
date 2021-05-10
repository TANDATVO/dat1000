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



namespace ZGearShop
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {



            //SqlConnection conn = new SqlConnection(@"Data Source=ITTHISPC\SQLEXPRESS;Initial Catalog=QLGEARTG;Integrated Security=True");
            //try
            //{
            //    conn.Open();
            //    string tk = txt_tk.Text;
            //    string mk = txt_mk.Text;
            //    string sql = "select * from TaiKhoan TenTK='" + tk + "' and MK='" + mk + "'";
            //    SqlCommand cmd = new SqlCommand(sql, conn);

            //    SqlDataReader data = cmd.ExecuteReader();

            //    if (data.Read() == true)
            //    {
            //        frm_quanly f = new frm_quanly();
            //        MessageBox.Show("Đăng Nhập Thành Công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        f.ShowDialog();
            //        this.Hide();
            //        this.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác! Vui Lòng Kiểm Tra lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }


            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Lỗi kết Nối","Thông Báo");
            //}

            frm_quanly f = new frm_quanly();
            string tk = txt_tk.Text;
            string mk = txt_mk.Text;
            if (tk == "admin" && mk == "123456")
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.ShowDialog();
                
            }
            else if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Chưa Nhập Đủ Thông Tin !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
                MessageBox.Show(" Tài Khoản Không Tồn Tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);





        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
