using Clockify2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clockify2
{
    public partial class profile : Form
    {
        Person person;
        ClockifyContext c = new ClockifyContext();
        public profile(Person p)
        {
            InitializeComponent();
            this.person = p;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void profile_Load(object sender, EventArgs e)
        {
            label1.Text = person.P_Name;
            pictureBox1.ImageLocation = this.person.imagelocation;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            // progressBar x = new progressBar();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 40;
            // progressBar1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            void openForm1(Person ma)
            {
                Application.Run(new Home_page(ma));
            }
            void opensettings()
            {
                openForm1(person);
            }
            this.Close();
            Thread th = new Thread(opensettings);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
