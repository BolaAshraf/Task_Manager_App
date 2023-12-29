using Clockify2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
namespace Clockify2
{
    public partial class Register : Form
    {
        
        public string? imagePath;
        public Register()
        {
            InitializeComponent();
            // UpgradeFullscreen();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string passwordhash = BCrypt.Net.BCrypt.HashPassword(password, salt);
            ClockifyContext C = new ClockifyContext();
            Person P = new Person()
            {
                P_Name = textBox1.Text,
                pass = passwordhash,
                email = textBox3.Text,
                birthdate = dateTimePicker1.Value,
                gender = (_Gender)comboBox1.SelectedIndex,
                imagelocation = imagePath,
                registeredAt = DateTime.Now
            };
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) && ((_Gender)comboBox1.SelectedIndex == _Gender.Male || (_Gender)comboBox1.SelectedIndex == _Gender.Female))
            {

                var per = C.Persons.Where(a => a.P_Name == textBox1.Text && a.pass == textBox2.Text ).FirstOrDefault();
                if (per == null)
                {
                    if (textBox3.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
                        {
                        C.Persons.Add(P);
                        C.SaveChanges();
                        string newPath = Environment.CurrentDirectory + "\\images\\Users\\" + P.P_Id + ".jpg";

                        try
                        {
                            File.Copy(imagePath, newPath);
                        }
                        catch (Exception)
                        {

                        }
                        P.imagelocation = newPath;
                        C.SaveChanges();
                        MessageBox.Show("Welcome");
                        Login l = new Login();
                        l.Show();
                        this.Hide();
                    }


                    else {
                        MessageBox.Show("you enterd invalid email");
                    }

                }

                else
                {
                    MessageBox.Show(" You already have an account !");
                }
            }
            else
            {
                MessageBox.Show("You didn't enter the required data");
            }


        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Login l = new Login();
            //l.Show();
            //this.Close();
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void openForm()
        {
            Application.Run(new Login());
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
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openFormB);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void openFormB()
        {
            Application.Run(new Welcome());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            if (img.ShowDialog() == DialogResult.OK)
            {
                imagePath = img.FileName;
                pictureBox1.ImageLocation = img.FileName;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
