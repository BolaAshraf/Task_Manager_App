using System.Security.Cryptography.Xml;

namespace Clockify2
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            UpgradeFullscreen();
        }
        private System.Drawing.Size oldsize = new System.Drawing.Size(300, 300);
        private System.Drawing.Point oldlocation = new System.Drawing.Point(0, 0);
        private System.Windows.Forms.FormWindowState oldstate = System.Windows.Forms.FormWindowState.Normal;
        private System.Windows.Forms.FormBorderStyle oldstyle = System.Windows.Forms.FormBorderStyle.Sizable;
        private bool fullscreen = false;
        /// <summary>
        /// Goes to fullscreen or the old state.
        /// </summary>
        private void UpgradeFullscreen()
        {
            if (!fullscreen)
            {
                oldsize = this.Size;
                oldstate = this.WindowState;
                oldstyle = this.FormBorderStyle;
                oldlocation = this.Location;
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
                fullscreen = true;
            }
            else
            {
                this.Location = oldlocation;
                this.WindowState = oldstate;
                this.FormBorderStyle = oldstyle;
                this.Size = oldsize;
                fullscreen = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        void openForm()
        {
            Application.Run(new Register());
        }
        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            UpgradeFullscreen();
        }
    }
}
