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
    public partial class frm_qlsanpham : Form
    {


        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=ITTHISPC\SQLEXPRESS;Initial Catalog=QLGEARTG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM SanPham ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            datagv_dssanpham.DataSource = table;
        }
        public frm_qlsanpham()
        {
            InitializeComponent();
        }




        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_qlsanpham_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }
    }
}
