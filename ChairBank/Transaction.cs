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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/mm/yyyy";
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker2.CustomFormat = "";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into [Transaction] values (@TID,@Transaction_type,@Amount,@Transaction_Date,@Account_id)", con);

            cnn.Parameters.AddWithValue("TID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("Transaction_type", textBox2.Text);
            cnn.Parameters.AddWithValue("Amount", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("Transaction_Date", dateTimePicker2.Value);
            cnn.Parameters.AddWithValue("Account_id", int.Parse(textBox5.Text));
            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Saved Successfully");
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from [Transaction]", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("update Transaction set Transaction_type = @Transaction_type,Amount = @Amount,Transaction_Date = @Transaction_Date,Account_id = @Account_id)", con);

            cnn.Parameters.AddWithValue("TID", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("Transaction_type", textBox2.Text);
            cnn.Parameters.AddWithValue("Amount", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("Transaction_Date", dateTimePicker2.Value);
            cnn.Parameters.AddWithValue("Account_id", int.Parse(textBox5.Text));
            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Updated Successfully");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete [Transaction] where TID = @TID", con);

            cnn.Parameters.AddWithValue("TID", int.Parse(textBox1.Text));
            cnn.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Deleted Successfully");
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("select * from [Transaction]", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Close(); 
        }
    }
}
