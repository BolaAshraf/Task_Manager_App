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
    public partial class Task : Form
    {
        Person person;
        public Task(Person pe)
        {
            InitializeComponent();
            this.person = pe;
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
    }
}
