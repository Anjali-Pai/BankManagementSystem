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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=OMKAR\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into customer (username,password,email,contact,name) values ('" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox2.Text + "','" +
this.textBox3.Text + "','" + this.textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted Successfully");
            con.Close();
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bankDataSet.customer);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    
    }
}
