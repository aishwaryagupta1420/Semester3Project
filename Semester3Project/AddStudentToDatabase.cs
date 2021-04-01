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
            textBox7.MaxLength = 10;
            textBox10.MaxLength = 2;
            textBox11.MaxLength = 2;
            textBox12.MaxLength = 2;
            textBox13.MaxLength = 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private bool validatingField()
        {
            //StudentID
            if (string.IsNullOrEmpty(textBox9.Text))
            {
                textBox9.Focus();
                errorProvider1.SetError(textBox9, "Please Enter Student ID");
                return false;
            }
            //First Name
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please Enter Fisrt Name");
                return false;
            }
            //Last Name
            if (string.IsNullOrEmpty(textBox5.Text))
            {

                textBox5.Focus();
                errorProvider1.SetError(textBox5, "Please Enter Last Name");
                return false;
            }
            //Mother Name
            if (string.IsNullOrEmpty(textBox2.Text))
            {

                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Please Enter Mother Name");
                return false;
            }
            //Father Name
            if (string.IsNullOrEmpty(textBox6.Text))
            {

                textBox6.Focus();
                errorProvider1.SetError(textBox6, "Please Enter Father Name");
                return false;
            }
            //Date of birth
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Focus();
                errorProvider1.SetError(textBox4, "Please Enter Date of birth");
                return false;
            }
            //Email ID
            if (string.IsNullOrEmpty(textBox8.Text))
            {

                textBox8.Focus();
                errorProvider1.SetError(textBox8, "Please Enter Email ID");
                return false;
            }
            //Address
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Please Enter Address");
                return false;
            }
            //phone number
            if (string.IsNullOrEmpty(textBox7.Text))
            {

                textBox7.Focus();
                errorProvider1.SetError(textBox7, "Please Enter 10th Percentage");
                return false;
            }
            //10th Percentage
            if (string.IsNullOrEmpty(textBox10.Text))
            {
                textBox10.Focus();
                errorProvider1.SetError(textBox10, "Please Enter 10th Percentage");
                return false;
            }
            //12th Percentage
            if (string.IsNullOrEmpty(textBox11.Text))
            {

                textBox11.Focus();
                errorProvider1.SetError(textBox11, "Please Enter 12th Percentage");
                return false;
            }
            //UG Percentage
            if (string.IsNullOrEmpty(textBox12.Text))
            {
                textBox12.Focus();
                errorProvider1.SetError(textBox12, "Please Enter UG Percentage");
                return false;
            }
            //PG Percentage
            if (string.IsNullOrEmpty(textBox13.Text))
            {

                textBox13.Focus();
                errorProvider1.SetError(textBox13, "Please Enter PG Percentage");
                return false;
            }
            return true;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            if (validatingField() == true)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from RegStudents where StudentID = " + textBox9.Text, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);
                int i = ds1.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Record Already Exists.");
                }
                else
                {
                    SqlCommand sc1 = new SqlCommand("Insert into RegStudents values(" + textBox9.Text + ", '" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + textBox8.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "' , " + textBox7.Text + ", " + textBox10.Text + ", " + textBox11.Text + ", " + textBox12.Text + ", " + textBox13.Text + " );", conn);
                    int obj1 = sc1.ExecuteNonQuery();
                    SqlCommand sc2 = new SqlCommand("Insert into NoPlacedStudents values(" + textBox9.Text + ", '" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + textBox8.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "' , " + textBox7.Text + ", " + textBox10.Text + ", " + textBox11.Text + ", " + textBox12.Text + ", " + textBox13.Text + " );", conn);
                    int obj2 = sc2.ExecuteNonQuery();
                    MessageBox.Show(obj1 + ": Record has been inserted");
                }

                conn.Close();


            }


            /*
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand sc1 = new SqlCommand("Insert into RegStudents values(" + textBox9.Text + ", '" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + textBox8.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "' , " + textBox7.Text+", " + textBox10.Text + ", " + textBox11.Text + ", " + textBox12.Text + ", " + textBox13.Text + " );", conn);
            int obj1 = sc1.ExecuteNonQuery();
            SqlCommand sc2 = new SqlCommand("Insert into NoPlacedStudents values(" + textBox9.Text + ", '" + textBox1.Text + "', '" + textBox5.Text + "', '" + textBox4.Text + "', '" + textBox8.Text + "', '" + textBox3.Text + "', '" + textBox2.Text + "', '" + textBox6.Text + "' , " + textBox7.Text + ", " + textBox10.Text + ", " + textBox11.Text + ", " + textBox12.Text + ", " + textBox13.Text + " );", conn);
            int obj2 = sc2.ExecuteNonQuery();
            MessageBox.Show(obj1+": Record has been inserted");
            conn.Close();
            */
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
