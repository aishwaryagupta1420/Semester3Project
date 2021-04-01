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
    public partial class AddStudWithPlacementDetails : Form
    {
        public AddStudWithPlacementDetails()
        {
            InitializeComponent();
        }
        private bool validatingField()
        {
            //StudentID
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please Enter Student ID");
                return false;
            }
            //company Name
            if (string.IsNullOrEmpty(textBox2.Text))
            {

                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Please Enter company Name");
                return false;
            }
            //package Name
            if (string.IsNullOrEmpty(textBox3.Text))
            {

                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Please Enter Package Name");
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

                SqlCommand cmd = new SqlCommand("select * from PlacedStudents where StudentID = " + textBox1.Text, conn);
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
                    //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
                    //conn.Open();

                    SqlCommand sc = new SqlCommand("insert into PlacedStudents(StudentID,FirstName,LastName,DOB,Email,Address,MotherName,FatherName,PhoneNumber,Percentage10th,Percentage12th,PercentageUG,PercentagePG) select StudentID,FirstName,LastName,DOB,Email,Address,MotherName,FatherName,PhoneNumber,Percentage10th,Percentage12th,PercentageUG,PercentagePG from NoPlacedStudents where StudentID=" + textBox1.Text, conn);
                    int obj = sc.ExecuteNonQuery();
                    SqlCommand sc2 = new SqlCommand("update PlacedStudents set CompanyName='" + textBox2.Text + "', Package=" + textBox3.Text + " where StudentID=" + textBox1.Text, conn);
                    sc2.ExecuteNonQuery();
                    SqlCommand sc3 = new SqlCommand("delete from NoPlacedStudents where StudentID=" + textBox1.Text, conn);
                    sc3.ExecuteNonQuery();

                    MessageBox.Show(obj + ": Record has been inserted");
                    
                }
                conn.Close();
            }
        }

        private void AddStudWithPlacementDetails_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choice_Operation cs = new Choice_Operation();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
