using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop_ImagesSwap
{
    public partial class Form1 : Form
    {
        private PictureBox pbSource;

        List<PictureBox> listPB;
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Image = Properties.Resources._1;
            this.pictureBox2.Image = Properties.Resources._2;
            this.pictureBox3.Image = Properties.Resources._3;
            listPB = new List<PictureBox>() 
            {
                this.pictureBox1,
                this.pictureBox2,
                this.pictureBox3
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (PictureBox pb in listPB)
            {
                pb.AllowDrop = true;
                pb.MouseDown += new MouseEventHandler(pb_MouseDown);
                pb.DragDrop += new DragEventHandler(pb_DragDrop);
                pb.DragEnter += new DragEventHandler(pb_DragEnter);

            }
        }
        private void pb_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pb_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pbGoal = (PictureBox)sender;
            //pbGoal.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            // if   условия разрешения swap images            
            (pbGoal.Image, pbSource.Image) = 
                ((Bitmap)e.Data.GetData(DataFormats.Bitmap), (Bitmap)pbGoal.Image);
        }
        
        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            pbSource = (PictureBox)sender;
            pbSource.DoDragDrop(pbSource.Image, DragDropEffects.Copy);
        }

    }
}
