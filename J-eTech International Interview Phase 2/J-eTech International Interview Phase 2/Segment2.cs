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
    public partial class Segment2 : Form
    {
        public Segment2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter a number");
            }
            else if (System.Convert.ToInt32(textBox1.Text) == 42)
            {
                MessageBox.Show("Correct");
                this.Close();
            }
            else
            {
                int failedguess = System.Convert.ToInt32(textBox1.Text);
                MessageBox.Show("Incorrect");
                textBox1.Text = "";
                listBox1.Visible = true;
                listBox1.Items.Add(failedguess);

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char val = e.KeyChar;

            if (!Char.IsDigit(val) && val != 8 && val != 46)
            {
                e.Handled = true;
            }
        }
    }
}
