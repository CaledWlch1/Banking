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
namespace ChairBank
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Account values (@Account_id,@Account_type,@Balance,@Date_Opened,@Customer_name)", con);

            cnn.Parameters.AddWithValue("Account_id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("Account_type", textBox2.Text);
            cnn.Parameters.AddWithValue("Balance", textBox3.Text);
            cnn.Parameters.AddWithValue("Date_Opened", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("Customer_name", textBox5.Text);
            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Saved Successfully");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Account", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update Account set Account_type = @Account_type,Balance = @Balance,Date_Opened = @Date_Opened,Customer_name = @Customer_name where Account_id =@Account_id ", con);

            cnn.Parameters.AddWithValue("Account_id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("Account_type", textBox2.Text);
            cnn.Parameters.AddWithValue("Balance", textBox3.Text);
            cnn.Parameters.AddWithValue("Date_Opened", dateTimePicker1.Value);
            cnn.Parameters.AddWithValue("Customer_name", textBox5.Text);
            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Updated Successfully");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete from Account where Account_id = @Account_id ", con);

            cnn.Parameters.AddWithValue("@Account_id", int.Parse(textBox1.Text));
            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Deleted Successfully");
        }

        private void Account_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Account", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Account where Customer_name = @Customer_name", con);
            cnn.Parameters.AddWithValue("Customer_name", textBox5.Text);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {

            menu menu = new menu();
            menu.Show();
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
