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
    public partial class Add_subtask : Form
    {
        int tid;
        public Add_subtask(int tid)
        {
            InitializeComponent();
            this.tid = tid; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClockifyContext context = new ClockifyContext();
            SubTask s = new SubTask()
            {
                st_name = textBox1.Text,
                TId = tid
            };
            context.SubTasks.Add(s);
            context.SaveChanges();
            this.Hide();
        }
    }
}
