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

namespace _8__quản_lý_khách_hàng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dulieu = @"Data Source=LAPTOP-QJB0H525;Initial Catalog=baitaplon;Integrated Security=True;Encrypt=False";
        string sql;
        SqlConnection ketnoi;
        SqlCommand th;
        SqlDataAdapter da;
        DataTable dt;


        private void button2_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(dulieu);
            ketnoi.Open();
            sql = "select * from quanlyphanhoikhachhang where idphanhoi like '"+txttimkiem.Text+"'";
            th = new SqlCommand(sql, ketnoi);
            SqlDataAdapter da = new SqlDataAdapter(th);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            ketnoi.Close();
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection ketnoi = new SqlConnection(dulieu);
            hienthi();
        }
        public void hienthi()
        {
            SqlConnection ketnoi = new SqlConnection(dulieu);
            ketnoi.Open();
            string sql = "select * from quanlyphanhoikhachhang";
            SqlCommand th = new SqlCommand(sql,ketnoi);
            SqlDataAdapter da = new SqlDataAdapter(th);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            ketnoi.Close();



        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int sodong = -1;
            sodong= dataGridView1.CurrentRow.Index;
            if (sodong != -1)
            {
                txtidphanhoi.Text = dataGridView1[0,sodong].Value.ToString();
                txtidkhachhang.Text = dataGridView1[1,sodong].Value.ToString();
                txtnoidungphanhoi.Text = dataGridView1[2,sodong].Value.ToString();
                txtngayphanhoi.Text = dataGridView1[3,sodong].Value.ToString();
                
            }
        }

        private void txtngayphanhoi_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidphanhoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection ketnoi = new SqlConnection(dulieu);
            ketnoi.Open();
            sql = "insert into quanlyphanhoikhachhang values( @txtidphanhoi,@txtidkhachhang,@txtnoidungphanhoi,@txtngayphanhoi)";
                th = new SqlCommand(sql, ketnoi);
            th.Parameters.AddWithValue("@txtidphanhoi", txtidphanhoi.Text);
            th.Parameters.AddWithValue("@txtidkhachhang", txtidkhachhang.Text);
            th.Parameters.AddWithValue("@txtnoidungphanhoi", txtnoidungphanhoi.Text);
            th.Parameters.AddWithValue("@txtngayphanhoi", DateTime.Parse(txtngayphanhoi.Text));
            th.ExecuteNonQuery();
            MessageBox.Show("Thêm thành công");
            ketnoi.Close();
            hienthi();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(dulieu);
            ketnoi.Open();
            sql= "update quanlyphanhoikhachhang set idkhachhang=@txtidkhachhang,noidungphanhoi=@txtnoidungphanhoi,ngayphanhoi=@txtngayphanhoi where idphanhoi=@txtidphanhoi";
            th = new SqlCommand(sql, ketnoi);
            th.Parameters.AddWithValue("@txtidphanhoi", txtidphanhoi.Text);
            th.Parameters.AddWithValue("@txtidkhachhang", txtidkhachhang.Text);
            th.Parameters.AddWithValue("@txtnoidungphanhoi", txtnoidungphanhoi.Text);
            th.Parameters.AddWithValue("@txtngayphanhoi", DateTime.Parse(txtngayphanhoi.Text));
            th.ExecuteNonQuery();
            MessageBox.Show("Sửa thành công");
            ketnoi.Close();
            hienthi();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(dulieu);
            ketnoi.Open();
            sql = "delete from quanlyphanhoikhachhang where idphanhoi=@txtidphanhoi";
            th = new SqlCommand(sql, ketnoi);
            th.Parameters.AddWithValue("@txtidphanhoi", txtidphanhoi.Text);
            if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { th.ExecuteNonQuery(); }
            ketnoi.Close();
            hienthi();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
