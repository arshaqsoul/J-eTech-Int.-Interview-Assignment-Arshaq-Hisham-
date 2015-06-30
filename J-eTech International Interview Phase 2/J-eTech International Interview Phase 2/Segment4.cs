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
    public partial class Segment4 : Form
    {
        public Segment4()
        {
            InitializeComponent();
        }

        public List<string> Sort(List<string> theList, char theChar)
        {
            List<string> filteredList = new List<string>();
            foreach(string item in theList)
            {
                if (item[0] == theChar)
                {
                    filteredList.Add(item);
                }

            } 
            listBox2.DataSource = filteredList;
            return filteredList;
            
            // fill me in
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a word to add to the list");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Please add some string items to the list");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter atleast one letter to filter the list");
            }
            else
            {
                Sort(listBox1.Items.Cast<string>().ToList(), textBox2.Text[0]);
            }
        }
        
    }
}
