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
    public partial class Segment1 : Form
    {
        public Segment1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            int count = 100;
            for (int i = 1; i <= count; i++)
            {
                if (i % 3 == 0 && i % 5 ==0)
                {
                    result = result + "SupportTraining, ";
                }
                else if (i % 3 == 0)
                {
                    result = result + "Support, ";
                }
                else if (i % 5 == 0)
                {
                    result = result + "Training, ";
                }
                else
                {
                    result = result + System.Convert.ToString(i) + ", ";
                    label2.Text = result;
                }
            }
        }
    }
}
