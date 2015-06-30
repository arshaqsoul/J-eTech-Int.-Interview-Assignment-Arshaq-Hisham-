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
    public partial class Segment5NewStudent : Form
    {
        public Segment5NewStudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtGpa.Text == "" || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                StudentClass.name = txtName.Text;
                StudentClass.dob = System.Convert.ToString(dobPickr.Value);
                StudentClass.gpa = System.Convert.ToDecimal(txtGpa.Text);
                if (comboBox1.SelectedIndex == 0)
                {
                    StudentClass.active = true;
                }
                else
                {
                    StudentClass.active = false;
                }
                Segment_5.Segment5Student seg5std = new Segment_5.Segment5Student();
                seg5std.Activate();
                this.Close();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Segment5NewStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtGpa.Text = "";
            txtName.Text = "";
            comboBox1.SelectedIndex=-1;
        }
    }
}
