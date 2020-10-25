using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndStruct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonClass pc = new PersonClass(textBox1.Text, Int32.Parse(textBox2.Text));
            PersonStruct ps = new PersonStruct(textBox1.Text, Int32.Parse(textBox2.Text));
            Change(pc, ps);
            txtClassAge.Text = pc.Age.ToString();
            txtStructAge.Text = ps.Age.ToString();
        }

        private void Change(PersonClass pc, PersonStruct ps)
        {
            pc.Age += 1;
            ps.Age += 1;
        }
    }
}
