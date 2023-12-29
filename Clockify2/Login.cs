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

namespace Clockify2
{
    public partial class Login : Form
    {

        public Login()
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClockifyContext C = new ClockifyContext();
            string username = textBox1.Text;
            string pass = textBox2.Text;
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string passwordhash = BCrypt.Net.BCrypt.HashPassword(pass, salt);
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {

                Person per = C.Persons.Where(a => a.P_Name == username).FirstOrDefault();
                void openForm(Person p)
                {
                    Application.Run(new Home_page(p));
                }
                void openhome()
                {
                    openForm(per);
                }
                if (per != null)
                {
                    bool b = false;
                    //for (int i = 0; i <per.P_Name.Length;i++)
                    //{
                    //    if (per.P_Name[i] != textBox1.Text[i])
                    //    {
                    //        b = true;
                    //        break;
                    //    }
                    //}
                    //if(per.P_Name != username)
                    //{
                    //    b = true;
                    //}
                    //if (!b)
                    //{
                    if (BCrypt.Net.BCrypt.Verify(pass, per.pass))
                    {
                        //if(string.Equals(textBox1.Text , per.P_Name , StringComparison.OrdinalIgnoreCase))
                        MessageBox.Show("Login successfully");
                        //else
                        // MessageBox.Show("Login notsuccessfully");


                        this.Close();
                        Thread th = new Thread(new ThreadStart(openhome));
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        MessageBox.Show("ERROR : Invalid password");
                    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("ERROR : Invalid user");
                    //}
                }
                else
                {
                    MessageBox.Show("ERROR : Invalid username");
                }

            }
            else
            {
                MessageBox.Show("ERROR : Please enter your username or password");
            }
        }


        //void openForm2(Person p)
        //{
        //    Application.Run(new Home_page(p));
        //}
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Thread th = new Thread(openForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void openForm1()
        {
            Application.Run(new Register());
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Thread th = new Thread(openForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
