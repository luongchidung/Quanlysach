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

namespace Quanlysach
{
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();

        }

        void load_data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DUNG;Initial Catalog=""Visual code"";Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from Sach", con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            dtgsach.DataSource = dt;
            con.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DUNG;Initial Catalog=""Visual code"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("update Sach set Tensach = '" + txttensach.Text + "',Gia = '" + Convert.ToDouble(txtgia.Text) + "',Soluong ='" + Convert.ToInt16(txtsoluong.Text) + "' where Masach = '" + txtmasach.Text + "'", con);
            con.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
                MessageBox.Show("Cập nhật dữ liệu thành công!");
            
            con.Close();
            load_data();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DUNG;Initial Catalog=""Visual code"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Insert into Sach values ('" + txtmasach.Text + "', '" + txttensach.Text + "','" + Convert.ToDouble(txtgia.Text) + "','" + Convert.ToInt16(txtsoluong.Text) + "')", con);
            con.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
                MessageBox.Show("Thêm mới dữ liệu thành công!");

            con.Close();
            load_data();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DUNG;Initial Catalog=""Visual code"";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("delete from Sach where Masach = '" + txtmasach.Text + "'", con);
            con.Open();
            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
                MessageBox.Show("Xoá dữ liệu thành công!");

            con.Close();
            load_data();
        }
    }
}
