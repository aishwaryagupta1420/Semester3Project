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
    public partial class ViewRegStudent : Form
    {
        public ViewRegStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AISH GUPTA\Documents\placementdb.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from RegStudents",conn);
            DataTable da = new DataTable();
            sda.Fill(da);
            dataGridView1.DataSource = da;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Choice_Operation cs = new Choice_Operation();
            cs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
