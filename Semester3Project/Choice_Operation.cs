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
    public partial class Choice_Operation : Form
    {
        public Choice_Operation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudentToDatabase addStudDB = new AddStudentToDatabase();
            addStudDB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRegStudent vRegStud = new ViewRegStudent();
            vRegStud.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStudWithoutPlacement vStudWoPl = new ViewStudWithoutPlacement();
            vStudWoPl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilterStudents fStud = new FilterStudents();
            fStud.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudWithPlacementDetails addStudWPl = new AddStudWithPlacementDetails();
            addStudWPl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPlacedStudents vPlStud = new ViewPlacedStudents();
            vPlStud.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
