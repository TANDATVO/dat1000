using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ZGearShop
{
    public partial class frm_nhanvien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=ITTHISPC\SQLEXPRESS;Initial Catalog=QLGEARTG;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void LoadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DataGV_dshienthi.DataSource = table;
        }
        public frm_nhanvien()
        {
            InitializeComponent();
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadData();
        }

        private void DataGV_dshienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
