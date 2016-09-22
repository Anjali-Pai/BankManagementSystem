using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace bank
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=OMKAR\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into customer (username,password,email,contact,name) values ('" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox2.Text + "','" +
this.textBox3.Text + "','" + this.textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Signup Successful");
            con.Close();
            Close();
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=OMKAR\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();

        }

        private void Signup_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
