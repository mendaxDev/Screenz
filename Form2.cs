using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screenz
{
    public partial class Form2 : Form
    {

        private SolidBrush myBrush;
        private Graphics myGraphics;
        private bool IsPainting;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Clipboard.GetImage();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            myBrush = new SolidBrush(Color.Red);
        }

        private void ExitApplication(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsPainting = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsPainting = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(IsPainting == true)
            {
                myGraphics = pictureBox1.CreateGraphics();
                myGraphics.FillEllipse(myBrush, e.X, e.Y, 3, 3);
            }
        }
    }
}
