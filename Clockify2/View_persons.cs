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
    public partial class View_persons : Form
    {
        ClockifyContext C = new ClockifyContext();
        public View_persons()
        {
            InitializeComponent();
        }
        private void View_persons_Load(object sender, EventArgs e)
        {
            var per = C.Persons.ToList();
            var pers = from pr in per select new {pr.P_Id, pr.P_Name, pr.email };
            dataGridView1.DataSource = pers.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
