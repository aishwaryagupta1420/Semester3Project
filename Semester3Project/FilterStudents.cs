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
    public partial class FilterStudents : Form
    {
        public FilterStudents()
        {
            InitializeComponent();
            textBox1.MaxLength = 2;
            textBox2.MaxLength = 2;
            textBox3.MaxLength = 2;
            textBox4.MaxLength = 2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool validatingField()
        {
            //10th Percentage
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please Enter 10th Percentage");
                return false;
            }
            //12th Percentage
            else if (string.IsNullOrEmpty(textBox2.Text))
            {

                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Please Enter 12th Percentage");
                return false;
            }
            //UG percentage
            else if (string.IsNullOrEmpty(textBox3.Text))
            {

                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Please Enter UG percentage");
                return false;
            }
            //PG percentage
            else if (string.IsNullOrEmpty(textBox4.Text))
            {

                textBox4.Focus();
                errorProvider1.SetError(textBox4, "Please Enter PG percentage");
                return false;
            }
            return true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            ViewFilteredStudents filStud = new ViewFilteredStudents();
            filStud.Show();
            */
            if (validatingField() == true)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from NoPlacedStudents where Percentage10th>=" + textBox1.Text + "and Percentage12th>=" + textBox2.Text + "and PercentageUG>=" + textBox3.Text + "and PercentagePG>=" + textBox4.Text, conn);
                DataTable da = new DataTable();
                sda.Fill(da);
                dataGridView1.DataSource = da;
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choice_Operation cs = new Choice_Operation();
            cs.Show();
        }
    }
}
