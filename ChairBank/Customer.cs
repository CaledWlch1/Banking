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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Costomer values (@costomer_id,@costomer_name,@phone,@email,@address)", con);

            cnn.Parameters.AddWithValue("costomer_id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("costomer_name", textBox2.Text);
            cnn.Parameters.AddWithValue("phone", textBox3.Text);
            cnn.Parameters.AddWithValue("email", textBox4.Text);
            cnn.Parameters.AddWithValue("address", textBox5.Text);
            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Saved Successfully");

        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Costomer", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update Costomer set costomer_name = @costomer_name,phone = @phone,email = @email,address = @address where costomer_id = @costomer_id ", con);

            cnn.Parameters.AddWithValue("costomer_id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("costomer_name", int.Parse(textBox2.Text));
            cnn.Parameters.AddWithValue("phone", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("email", int.Parse(textBox4.Text));
            cnn.Parameters.AddWithValue("address", int.Parse(textBox5.Text));
            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Updated Successfully");

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete Costomer where costomer_id = @costomer_id ", con);

            cnn.Parameters.AddWithValue("costomer_id", int.Parse(textBox1.Text));
            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Deleted Successfully");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from Costomer", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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
    }
}
