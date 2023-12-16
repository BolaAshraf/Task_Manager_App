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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClockifyContext C = new ClockifyContext();
            string username = textBox1.Text,
                password = textBox2.Text;
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {

                Person per = C.Persons.Where(a => a.P_Name == username && a.pass == password).FirstOrDefault();
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
                    MessageBox.Show("Login successfully");
                    //Home_page h = new Home_page(per);
                    //h.Show();
                    //this.Hide();

                    this.Close();
                    Thread th = new Thread(new ThreadStart(openhome));
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
                else
                {
                    MessageBox.Show("ERROR : Invalid username or password");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openFormB);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void openFormB()
        {
            Application.Run(new Register());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
