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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form3()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=OMKAR\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=OMKAR\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
            con.Open();
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            SqlCommand cmd = new SqlCommand("select username,pswd from admin where username='" + textBox1.Text + "'and pswd='" + textBox2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form4 frm1 = new Form4(Username, Password);
                frm1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }

            con.Close();
        }
    }
}
