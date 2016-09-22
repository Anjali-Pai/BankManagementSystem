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
    public partial class Deposit : Form
    {
        String user, pwd;
        public Deposit(String Username,String Password)
        {
            InitializeComponent();
            user = Username;
            pwd = Password;

        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=OMKAR\\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True";
            con.Open();
            string amt = textBox1.Text;

            SqlCommand mySelectCommand = new SqlCommand();
            mySelectCommand.CommandText = "UPDATE [customer] SET balance=balance+@amt WHERE [username]=@user";
            mySelectCommand.Parameters.AddWithValue("@amt", amt);
            mySelectCommand.Parameters.AddWithValue("@user", user);
            mySelectCommand.Connection = con;
            mySelectCommand.ExecuteNonQuery();

            Book f1 = new Book(user,pwd);
            f1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
