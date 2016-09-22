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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=OMKAR\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete from [customer] where username=@train";
            cmd.Parameters.AddWithValue("@train", textBox1.Text.ToString());
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankDataSet1.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bankDataSet1.customer);

        }
    }
}
