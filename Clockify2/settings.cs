using Clockify2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clockify2
{
    public partial class settings : Form
    {
        ClockifyContext context = new ClockifyContext();
        Person person;

        public static string Birth { get; internal set; }

        public settings(Person ma)
        {
            InitializeComponent();
            UpgradeFullscreen();
            this.person = ma;
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
        private void settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = person.P_Name;
            textBox3.Text = person.email;
            comboBox1.SelectedIndex = (int)person.gender;
            dateTimePicker1.Value = person.birthdate;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                person.P_Name = textBox1.Text;

                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    person.email = textBox3.Text;

                    if (((_Gender)comboBox1.SelectedIndex == _Gender.Male || (_Gender)comboBox1.SelectedIndex == _Gender.Female))
                    {
                        person.gender = (_Gender)comboBox1.SelectedIndex;

                        if (!string.IsNullOrWhiteSpace(textBox2.Text))
                        {
                            if (textBox2.Text == person.pass)
                            {
                                if (!string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
                                {
                                    if (textBox4.Text == textBox5.Text)
                                    {
                                        person.pass = textBox5.Text;

                                        context.Persons.Update(person);
                                        context.SaveChanges();
                                        MessageBox.Show("Edited successfully");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error: New password doesn't match confirm password");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Error: you should enter new password");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Error: The password you entered doesn't match your current password");
                            }
                        }
                        else if (string.IsNullOrWhiteSpace(textBox2.Text) && string.IsNullOrWhiteSpace(textBox4.Text) && string.IsNullOrWhiteSpace(textBox4.Text))
                        {
                            context.Persons.Update(person);
                            context.SaveChanges();
                            MessageBox.Show("Edited successfully");
                        }

                    }
                    else
                    {
                        MessageBox.Show("ERROR : you should select correctly your gender");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: You should enter your email");
                }
            }
            else
            {
                MessageBox.Show("ERROR : you should enter your name ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            void openForm(Person p)
            {
                Application.Run(new Home_page(p));
            }
            void openhomeB()
            {
                openForm(person);
            }
            this.Close();
            Thread th = new Thread(openhomeB);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var per = context.Persons.Where(a=>a.P_Id==person.P_Id).ExecuteDelete();
            MessageBox.Show("Your Account has been deleted successfully");
            this.Close();
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        void openForm()
        {
            Application.Run(new Register());
        }
    }
}

