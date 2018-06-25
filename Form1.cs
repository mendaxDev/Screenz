using ScreenZ;
using ScreenZ.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Screenz
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();
        ScreenZ.Settings form3 = new ScreenZ.Settings();
        int num = 1;
        string myDir = "C:\\ScreenZ";

        private static Random rnd = new Random();

        public object OpenFolderDialog { get; private set; }

        //Take Screenshot

        private void screenBtn_Click(object sender, EventArgs e)
        {
            showBtn.Enabled = true;
            folderBtn.Enabled = true;
            deleteBtn.Enabled = true;
            saveBtn.Enabled = true;
            TakeSnapshot();
        }

        //Close Application

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Screenshot Method

        public void TakeSnapshot()
        {
            try
            {
                this.Opacity = 0;
                Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(printscreen as Image);
                graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
                Clipboard.SetImage(printscreen);
                bunifuCustomLabel2.Text = "Copied to clipboard.";
                this.Opacity = 100;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Form Load Method

        private void Form1_Load(object sender, EventArgs e)
        {

            const int margin = 10;
            int x = Screen.PrimaryScreen.WorkingArea.Right -
                this.Width - margin;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom -
                this.Height - margin;
            this.Location = new Point(x, y);

            bool exists = System.IO.Directory.Exists(myDir);
            if (!exists)
                System.IO.Directory.CreateDirectory(myDir);

            hotkeyLabel.Text = "Hotkey: " + File.ReadAllText("settings.scd");

        }

        //Delete Latest Screenshot

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\ScreenZ\\Screenshot" + num.ToString() + ".png");
            num--;

            if (num <= 0)
                num = 0;

            bunifuCustomLabel2.Text = "Last Screenshot deleted.";

        }

        //Save Screenshot From Clipboard

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (File.Exists("C:\\ScreenZ\\Screenshot" + num.ToString() + ".png"))
                num++;
            Clipboard.GetImage().Save(myDir + "\\Screenshot" + num.ToString() + ".png", ImageFormat.Png);

            bunifuCustomLabel2.Text = "Screenshot" + num.ToString() + " saved.";

        }

        //Open Settings

        //Show Picture
        
        private void showBtn_Click(object sender, EventArgs e)
        {
            if (form2.Visible)
            {
                form2.Hide();
                showBtn.Iconimage = Resources.eye;
            }

            else
            {
                form2.Show();
                showBtn.Iconimage = Resources.eye_slash;
            }

        }

        //Open ScreenZ Folder

        private void folderBtn_Click(object sender, EventArgs e)
        {
            Process.Start(myDir); 
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            if (form3.Visible)
            {
                form3.Hide();
                hotkeyLabel.Text = "Hotkey: " + File.ReadAllText("settings.scd");
            }

            else
                form3.Show();  
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
