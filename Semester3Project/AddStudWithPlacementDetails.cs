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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select * from NoPlacedStudents where StudentID="+ textBox1.Text, conn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            SqlCommand sc = new SqlCommand("insert into PlacedStudents(StudentID,FirstName,LastName,DOB,Email,Address,MotherName,FatherName,PhoneNumber,Percentage10th,Percentage12th,PercentageUG,PercentagePG) select StudentID,FirstName,LastName,DOB,Email,Address,MotherName,FatherName,PhoneNumber,Percentage10th,Percentage12th,PercentageUG,PercentagePG from NoPlacedStudents where StudentID=" + textBox1.Text, conn);
            int obj=sc.ExecuteNonQuery();
            SqlCommand sc2 = new SqlCommand("update PlacedStudents set CompanyName='" + textBox2.Text+ "', Package=" + textBox3.Text +" where StudentID="+textBox1.Text, conn);
            sc2.ExecuteNonQuery();
            SqlCommand sc3 = new SqlCommand("delete from NoPlacedStudents where StudentID=" + textBox1.Text, conn);
            sc3.ExecuteNonQuery();



            //string Fname = "select FirstName from NoPlacedStudents where StudentID="+ textBox1.Text;
            //SqlCommand sc1= new SqlCommand(,conn)
            //string Lname = "select LastName from NoPlacedStudents where StudentID=" + textBox1.Text;
            //String MomName = "select MotherName from NoPlacedStudents where StudentID=" + textBox1.Text;
            //String DadName = "select FatherName from NoPlacedStudents where StudentID=" + textBox1.Text;
            //String bday = "select DOB from NoPlacedStudents where StudentID=" + textBox1.Text;
            //String addr = "select Address from NoPlacedStudents where StudentID=" + textBox1.Text;
            //string phno = "select PhoneNumber from NoPlacedStudents where StudentID=" + textBox1.Text;



            //SqlCommand sc1 = new SqlCommand("insert (StudentID, FirstName, LastName, DOB, Email, Address, MotherName, FatherName, PhoneNumber) into PlacedStudents select StudentID, FirstName, LastName, DOB, Email, Address, MotherName, FatherName, PhoneNumber from NoPlacedStudents where StudentID=" + textBox1.Text, conn);
            //SqlCommand sc2 = new SqlCommand("insert (CompanyName, Package) into PlacedStudents values('" + textBox2.Text + "', "+ textBox3.Text + ") where StudentID="+ textBox1,conn);
            //int obj1 = sc1.ExecuteNonQuery();
            //int obj2 = sc2.ExecuteNonQuery();
            MessageBox.Show(obj + ": Record has been inserted");
            conn.Close();
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
