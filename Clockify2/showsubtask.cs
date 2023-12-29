using Microsoft.EntityFrameworkCore;
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
    public partial class showsubtask : Form
    {
        ClockifyContext context= new ClockifyContext();
        int tasks;
        public showsubtask(int task )
        {
            InitializeComponent();
            this.tasks = task;
        }

        private void showsubtask_Load(object sender, EventArgs e)
        {
            //SubTask sub = new SubTask();
            //var query = from sub1 in context.SubTasks
            //            where taskk.taskId ==sub1.TId
            //            select new {sub.st_name, sub.st_id};
            //dataGridView1.DataSource = query.ToList();

            var allsubtask = context.SubTasks.Where(a => a.TId == tasks).ToList();

           // var allsubtask = context.SubTasks.ToList();
            var tah = from ath in allsubtask select new { ath.st_id, ath.st_name };
            dataGridView1.DataSource = tah.ToList();
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "delete_subtask", Name = "delete_subtask", UseColumnTextForButtonValue = true });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int st_id = Convert.ToInt32(row.Cells["st_id"].Value);
                var subTask = context.SubTasks.Where(a => a.st_id == st_id).FirstOrDefault();
                if (e.ColumnIndex == dataGridView1.Columns["delete_subtask"].Index)
                {
                    context.SubTasks.Where(b => b.st_id == subTask.st_id && b.st_name == subTask.st_name).ExecuteDeleteAsync();
                    this.Hide();
                }
            }
        }
    }
}
