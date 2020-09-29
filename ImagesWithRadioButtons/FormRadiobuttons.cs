using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesWithRadioButtons
{
    public partial class FormRadiobuttons : Form
    {
        private FormImages fmImages;
        public FormRadiobuttons()
        {
            InitializeComponent();
            fmImages = new FormImages();
            fmImages.Show();
        }

        private void FormRadiobuttons_Load(object sender, EventArgs e)
        {
            string currentDir = Directory.GetCurrentDirectory();
            groupBox1.Controls.Clear();
            string[] nameImages = Directory
                .GetFiles(currentDir + "\\Images\\", "*.jpg");
            foreach (string item in nameImages)
            {
                RadioButton rb = new RadioButton();
                rb.Text = Path.GetFileName(item);
                rb.Left = 50;
                rb.Top = 50 + groupBox1.Controls.Count * 30;

                rb.CheckedChanged += new EventHandler(SetImage);

                groupBox1.Controls.Add(rb);
            }
        }

        private void SetImage(object sender, EventArgs e)
        {
            string curDir = Environment.CurrentDirectory;
            string nameFile = curDir + @"\Images\" + ((RadioButton)sender).Text;
            Bitmap bmp = new Bitmap(nameFile);

            fmImages.pictureBox1.Image = bmp;
        }

        private void FormRadiobuttons_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fmImages.Location = new Point(Left + Width, Top);
                // Left Top
                fmImages.WindowState = FormWindowState.Normal;
            }
            else
            {
                //fmImages.Hide();
                fmImages.WindowState = FormWindowState.Minimized;
            }

        }

        private void FormRadiobuttons_Move(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                fmImages.Location = new Point(Left + Width, Top);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                fmImages.Location = new Point(Left + Width, Top);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void FormRadiobuttons_MouseClick(object sender, MouseEventArgs e)
        {
            FormRadiobuttons_Load(null, EventArgs.Empty);
        }
    }
}
