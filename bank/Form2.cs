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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form2()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SHEETAL-PC\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SHEETAL-PC\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SHEETAL-PC\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
            con.Open();
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select username,password from customer where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 0)
            {
                this.Hide();
                Book frm1 = new Book(Username, Password);
                frm1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Signup f1 = new Signup();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=OMKAR\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
            con.Open();
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select username,password from customer where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Book frm1 = new Book(Username, Password);
                frm1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }

            con.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
