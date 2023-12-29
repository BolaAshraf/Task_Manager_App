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
    public partial class Addtask : Form
    {
        Person person;
        public Addtask(Person pe)
        {
            InitializeComponent();
            this.person = pe;
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
        private void Task_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClockifyContext context = new ClockifyContext();
            Data.Task task = new Data.Task()
            {
                PId = person.P_Id,
                taskName = textBox1.Text,
                priority = (_priority)comboBox1.SelectedIndex,
                StartTime = dateTimePicker2.Value,
                EndTime = dateTimePicker3.Value,
                description = textBox3.Text
            };
            context.Tasks.Add(task);
            context.SaveChanges();
            MessageBox.Show("Task added successfully");
            //SubTask sb = new SubTask()
            //{
            //    st_name = textBox1.Text,
            //    TId = task.taskId
            //};
            //context.SubTasks.Add(sb);
            //context.SaveChanges();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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
