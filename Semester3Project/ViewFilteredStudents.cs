using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester3Project
{
    public partial class ViewFilteredStudents : Form
    {
        public ViewFilteredStudents()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from RegStudents where ", conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dataGridView1.DataSource = da;
            */
        }
    }
}
