using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtons
{
    public partial class Form1 : Form
    {
        private Color[] colors = new Color[] { 
            Color.Red, Color.Green, Color.Blue
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                int index = Convert.ToInt32(((RadioButton)sender).Tag.ToString());
                panel1.BackColor = colors[index];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (rb.Checked)
                {
                    int index = Convert.ToInt32(rb.Tag.ToString());
                    panel1.BackColor = colors[index];
                    break;
                }
            }
        }
    }
}
