using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            panel1.AllowDrop = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        { // когда вносим объекты на этот объект
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        { // когда мы отпускаем переносимые объекты
            string[] nameFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            pictureBox1.Load(nameFiles[0]);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] nameFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            int index = 0;
            foreach (PictureBox pb in groupBox1.Controls)
            { // if
                pb.Load(nameFiles[index++]);
                pb.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }
    }
}
