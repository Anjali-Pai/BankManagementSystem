using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bank
{
    public partial class Form4 : Form
    {
        public Form4(String username,String password)
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f1 = new Form6();
            f1.ShowDialog();
            this.Close();
        }
    }
}
