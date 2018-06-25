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

namespace ScreenZ
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Right -
            this.Width - 10;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom -
            this.Height - 70;
            this.Location = new Point(x, y);

            listBox1.SelectedItem = File.ReadAllText("settings.scd");

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            File.WriteAllText("settings.scd", listBox1.Text);
        }
    }
}
