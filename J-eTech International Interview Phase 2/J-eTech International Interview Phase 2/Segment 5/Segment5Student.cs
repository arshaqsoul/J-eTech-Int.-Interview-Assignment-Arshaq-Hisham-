using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_eTech_International_Interview_Phase_2.Segment_5
{
    public partial class Segment5Student : Form
    {
        public Segment5Student()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segment_5.Segment5NewStudent seg5nwstd = new Segment_5.Segment5NewStudent();
            seg5nwstd.Show();
        }

        private void Segment5Student_Load(object sender, EventArgs e)
        {
        }
        private void Segment5Student_Activated(object sender, EventArgs e)
        {
            StudentClass.AllStudents(this.dataGridView2);

            if (StudentClass.name != "" && StudentClass.dob != "" && StudentClass.gpa != null && StudentClass.active != null)
            {

                object[] row = new object[] { StudentClass.name, StudentClass.dob, StudentClass.gpa, StudentClass.active };
                dataGridView1.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=1; i< dataGridView1.Rows.Count; i++)
            {
                StudentClass.StudentInsert(System.Convert.ToString(dataGridView1.Rows[i].Cells["StdName"].Value),
                System.Convert.ToString(dataGridView1.Rows[i].Cells["dob"].Value),
                System.Convert.ToDouble(dataGridView1.Rows[i].Cells["gpa"].Value),
                System.Convert.ToBoolean(dataGridView1.Rows[i].Cells["Act"].Value));
            }
            StudentClass.name = ""; StudentClass.dob = ""; StudentClass.gpa = 0; StudentClass.active = false;
            StudentClass.AllStudents(this.dataGridView2);
            dataGridView1.Rows.Clear();
            MessageBox.Show("All record/s have been updated to the database");
        }
    }
}
