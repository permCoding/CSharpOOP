using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelsMoving
{
    public partial class Form1 : Form
    {
        private int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "Down";
            x = e.X; y = e.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = e.X.ToString() + " : " +  e.Y.ToString();
            if (e.Button == MouseButtons.Left) 
            {
                ((Label)sender).Left += (e.X - x);
                ((Label)sender).Top += (e.Y - y);
                PrintPosition();
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            //PrintPosition();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Label lbl = new Label();

            lbl.Name = "label2";
            lbl.Text = "label2";
            lbl.Left = 222;
            lbl.Top = 222;
            lbl.Font = new Font("Consolas", 16);
            lbl.AutoSize = true;

            MouseEventHandler ev = new MouseEventHandler(this.label1_MouseDown);
            lbl.MouseDown += ev;
            lbl.MouseMove += new MouseEventHandler(this.label1_MouseMove);
            lbl.MouseUp += new MouseEventHandler(this.label1_MouseUp);

            this.Controls.Add(lbl);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 
        }

        private void PrintPosition()
        {
            this.Text = label1.Left.ToString() + " : " + label1.Top.ToString();
        }
    }
}
