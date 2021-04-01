using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Semester3Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar='*';
            textBox2.MaxLength = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please Enter User Name");
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {

                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Please Enter User Name");
            }




            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where username ='"+textBox1.Text+"' and password='"+textBox2.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Choice_Operation co = new Choice_Operation();
                co.Show();
            }
            else
                MessageBox.Show("Please enter correct Username and Password","alert",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
