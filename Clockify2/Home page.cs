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
    public partial class Home_page : Form
    {
        Person m = new Person();
        ClockifyContext c = new ClockifyContext();
        public Home_page(Person pr)
        {
            InitializeComponent();
            this.m = pr;
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void myTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Home_page_Load(object sender, EventArgs e)
        {
            var alltasks = c.Tasks.ToList();
            dataGridView1.DataSource = alltasks;
            pictureBox1.ImageLocation = this.m.imagelocation;
            linkLabel1.Text = this.m.P_Name;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            void openForm1(Person ma)
            {
                Application.Run(new settings(ma));
            }
            void opensettings()
            {
                openForm1(m);
            }
            this.Close();
            Thread th = new Thread(opensettings);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void addNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            void openForm(Person p)
            {
                Application.Run(new Task(p));
            }
            void openhome()
            {
                openForm(m);
            }
            this.Close();
            Thread th = new Thread(openhome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openFormB);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void openFormB()
        {
            Application.Run(new Login());
        }
    }
}
