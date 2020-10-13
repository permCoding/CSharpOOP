using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReSortWord
{
    public partial class Form1 : Form
    {
        private string symbols = "ABCD";
        public Form1()
        {
            InitializeComponent();
            txtData.Text = symbols;
        }
        private string ShuffleString(string data)
        {
            char[] arr = data.ToCharArray();
            Random rnd = new Random();
            arr = arr.OrderBy(item => rnd.Next(-1, 1)).ToArray();
            return String.Join("", arr);
        }
        private void btnSuffle_Click(object sender, EventArgs e)
        {
            string data = txtData.Text;
            txtData.Text = ShuffleString(data);
        }
        private string GenRndString()
        {
            HashSet<char> set = new HashSet<char>();
            Random rnd = new Random();
            int len = txtData.Text.Length;
            while (set.Count < len)
            {
                set.Add(symbols[rnd.Next(0, len)]);
            }
            return String.Join("", set);
        }
        private void btnGenStr_Click(object sender, EventArgs e)
        {
            txtData.Text = GenRndString();
        }

        private void btnSolver_Click(object sender, EventArgs e)
        {
            Solver slr = new Solver(txtData.Text, symbols.Substring(0, txtData.Text.Length));
            slr.Find();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(slr.Result.ToArray());
        }
    }
}
