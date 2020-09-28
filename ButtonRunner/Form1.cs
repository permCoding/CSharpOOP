using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonRunner
{
    public partial class Form1 : Form
    {
        Random rnd;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //button2.Left = rnd.Next(this.ClientSize.Width - button2.Width);
            //button2.Top = rnd.Next(this.ClientSize.Height - button2.Height);

            button2.Location = new Point(
                    rnd.Next(this.ClientSize.Width - button2.Width),
                    rnd.Next(this.ClientSize.Height - button2.Height)
                );
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Control.ModifierKeys == Keys.Alt) &&
                e.KeyCode.ToString() == "F4")
            {
                e.Handled = true;
            }
        }
    }
}
