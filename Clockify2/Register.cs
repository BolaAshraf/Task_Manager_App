using Clockify2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clockify2
{
    public partial class Register : Form
    {
        public string? imagePath;
        public Register()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClockifyContext C = new ClockifyContext();
            Person P = new Person()
            {
                P_Name = textBox1.Text,
                pass = textBox2.Text,
                email = textBox3.Text,
                birthdate = dateTimePicker1.Value,
                gender = (_Gender)comboBox1.SelectedIndex,
                imagelocation = imagePath
            };
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) && ((_Gender)comboBox1.SelectedIndex == _Gender.Male || (_Gender)comboBox1.SelectedIndex == _Gender.Female))
            {
                //if((_Gender)comboBox1.SelectedIndex != _Gender.Male || (_Gender)comboBox1.SelectedIndex != _Gender.Female)
                //{
                //    MessageBox.Show("Please, select gender");
                //}
                //else
                //{
                var per = C.Persons.Where(a => a.P_Name == textBox1.Text && a.pass == textBox2.Text && a.email == textBox3.Text).FirstOrDefault();
                if (per == null)
                {

                    string newPath = Environment.CurrentDirectory + "\\images\\Users\\" + P.P_Id + ".jpg";
                    try
                    {
                        File.Copy(imagePath, newPath);
                    }
                    catch (Exception)
                    {

                    }
                    P.imagelocation = newPath;
                    C.Persons.Add(P);
                    C.SaveChanges();
                    MessageBox.Show("Welcome");
                    Login l = new Login();
                    l.Show();
                    this.Hide();
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            if (img.ShowDialog() == DialogResult.OK)
            {
                imagePath = img.FileName;
                pictureBox1.ImageLocation = img.FileName;
            }
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
    }
}
