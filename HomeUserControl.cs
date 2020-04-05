using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            productUserControl1.Hide();
            eventUserControl1.Hide();
            contactUserControl1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productUserControl1.Hide();
            eventUserControl1.Hide();
            contactUserControl1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productUserControl1.Show();
            productUserControl1.BringToFront();
            eventUserControl1.Hide();
            contactUserControl1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eventUserControl1.Show();
            eventUserControl1.BringToFront();
            productUserControl1.Hide();
            contactUserControl1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contactUserControl1.Show();
            contactUserControl1.BringToFront();
            productUserControl1.Hide();
            eventUserControl1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
