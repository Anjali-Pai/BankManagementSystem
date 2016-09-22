using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bank
{
    public partial class Book : Form
    {
        String user;
        String pwd;
        public Book(String Username, String Password)
        {

            InitializeComponent();
            user = Username;
            pwd = Password;
        }


        private void Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bankDataSet2.customer);
            SqlConnection con = new SqlConnection("Data Source=OMKAR\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit frm1 = new Deposit(user, pwd);
            frm1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            With frm1 = new With(user, pwd);
            frm1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            this.Close();
        }
    }
}
