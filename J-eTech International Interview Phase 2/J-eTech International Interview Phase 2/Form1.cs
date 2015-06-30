using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_eTech_International_Interview_Phase_2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeg1_Click(object sender, EventArgs e)
        {
            Segment1 seg1 = new Segment1();
            seg1.Show();

        }

        private void btnSeg2_Click(object sender, EventArgs e)
        {
            Segment2 seg2 = new Segment2();
            seg2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Segment3 seg3 = new Segment3();
            seg3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Segment4 seg4 = new Segment4();
            seg4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Segment5 seg5 = new Segment5();
            seg5.Show();
        }
    }
}
