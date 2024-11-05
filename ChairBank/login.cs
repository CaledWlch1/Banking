using System;
using System.Data;
using System.Data.SqlClient;

namespace ChairBank
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        

        private void login_button_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=CALEDWLCH;Initial Catalog=Chair;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            String username = txtusername.Text;
            String password = txtpassword.Text;

            SqlCommand cmd = new SqlCommand("select username,password from Acc where username ='" + txtusername.Text + "' and password ='" + txtpassword.Text +"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable(); 
            da.Fill(dt);
            if (dt.Rows.Count > 0 )
            {
                menu menu = new menu();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }

            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
