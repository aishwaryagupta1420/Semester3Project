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
    public partial class AddStudentToDatabase : Form
    {
        public AddStudentToDatabase()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sc1 = new SqlCommand("Insert into RegStudents values(" + textBox9.Text + ", '" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + textBox8.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "' , " + textBox7.Text+", " + textBox10.Text + ", " + textBox11.Text + ", " + textBox12.Text + ", " + textBox13.Text + " );", conn);
            int obj1 = sc1.ExecuteNonQuery();
            SqlCommand sc2 = new SqlCommand("Insert into NoPlacedStudents values(" + textBox9.Text + ", '" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + textBox8.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "' , " + textBox7.Text + ", " + textBox10.Text + ", " + textBox11.Text + ", " + textBox12.Text + ", " + textBox13.Text + " );", conn);
            int obj2 = sc2.ExecuteNonQuery();
            MessageBox.Show(obj1+": Record has been inserted");
            conn.Close();
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
