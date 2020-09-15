using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpOOP
{
    public partial class Form1 : Form
    {
        // 
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //this.tbNumber.Text += (sender as Button).Text;
            tbNumber.Text += ((Button)sender).Text;
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text.Length > 0)
            {
                tbNumber.Text = tbNumber.Text.Substring(0, tbNumber.Text.Length - 1);
            }   
        }
    }
}
