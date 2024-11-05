using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChairBank
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            Customer Custu = new Customer();
            Custu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account Acc = new Account();
            Acc.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transaction tr = new Transaction();
            tr.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
