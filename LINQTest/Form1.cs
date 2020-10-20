using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txtData.Text;

            char[] sep = new char[] { ' ', '|', '-' };
            //string[] arr = s.Split(sep);
            //arr = arr.Skip(3).ToArray();
            //txtResult.Text = String.Join(" ", arr);

            //txtResult.Text = txtData
            //    .Text
            //    .Split(sep)
            //    .Select(item => Convert.ToInt32(item))
            //    .Sum()
            //    .ToString();

            //txtResult.Text = string.Join(" ", txtData
            //    .Text
            //    .Split(sep)
            //    .Select(item => Convert.ToInt32(item))
            //    .Where(item => item % 2 > 0)
            //    .ToArray()
            //);

            txtResult.Text = string.Join(" ", txtData
                .Text
                .Split(sep)
                .Select(item => Convert.ToInt32(item))
                .OrderByDescending(item => item)
                .ToArray()
            );

            // стиль запросы
            // стиль методы
        }
    }
}
