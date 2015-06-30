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
    public partial class Segment5 : Form
    {
        public Segment5()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Segment_5.Segment5Student seg5std = new Segment_5.Segment5Student();
            seg5std.Show();
        }
    }
}
