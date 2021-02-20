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

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            ViewFilteredStudents filStud = new ViewFilteredStudents();
            filStud.Show();
            */
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from NoPlacedStudents where Percentage10th>="+textBox1.Text+ "and Percentage12th>="+ textBox2.Text+ "and PercentageUG>="+ textBox3.Text+ "and PercentagePG>="+ textBox4.Text, conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dataGridView1.DataSource = da;
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
