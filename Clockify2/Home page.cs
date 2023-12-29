using Clockify2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            UpgradeFullscreen();
            this.m = pr;
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


        private void Home_page_Load(object sender, EventArgs e)
        {

            var alltasks = c.Tasks.Where(t => t.PId == m.P_Id).ToList();
            var tah = from ath in alltasks select new { ath.taskId, ath.taskName, ath.StartTime, ath.EndTime };
            dataGridView1.DataSource = tah.ToList();
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Add subtask", Name = "Add subtask", UseColumnTextForButtonValue = true });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Show subtask", Name = "Show subtask", UseColumnTextForButtonValue = true });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Delete Task", Name = "Delete Task", UseColumnTextForButtonValue = true });
            pictureBox8.ImageLocation = this.m.imagelocation;

            linkLabel1.Text = ("Welcome, " + this.m.P_Name);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //profile newForm = new profile(m);
            //newForm.Show();2
            //this.Hide();
            void openForm(Person p)
            {
                Application.Run(new profile(p));
            }
            void openhomeB()
            {
                openForm(m);
            }
            this.Close();
            Thread th = new Thread(openhomeB);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            void openForm(Person p)
            {
                Application.Run(new Addtask(p));
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

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            void openForm1(Person ma)
            {
                Application.Run(new Addtask(ma));
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int t_id = Convert.ToInt32(row.Cells["taskId"].Value);
                if (e.ColumnIndex == dataGridView1.Columns["Add subtask"].Index)
                {
                    Add_subtask add_Subtask = new Add_subtask(t_id);
                    add_Subtask.Show();
                }
                if (e.ColumnIndex == dataGridView1.Columns["Delete Task"].Index)
                {
                    var t = c.Tasks.Where(a => a.taskId == t_id).ExecuteDelete();
                    MessageBox.Show("Task Deleted successfully");



                }
                if (e.ColumnIndex == dataGridView1.Columns["Show subtask"].Index)
                {
                    // var task = c.Tasks.Where(a => a.taskId == t_id).FirstOrDefault();
                    showsubtask show = new showsubtask(t_id);
                    show.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void openForm1(Person ma)
            {
                Application.Run(new profile(ma));
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)

        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(openFormB);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }


    }
}
