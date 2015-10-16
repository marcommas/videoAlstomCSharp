using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoAlstom
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btVideo1_Click(object sender, EventArgs e)
        {
            Login login = new Login(1);            
            login.Show();

            this.BringToFront();
          
        }

        private void btVideo2_Click(object sender, EventArgs e)
        {
            Login login = new Login(2);
            login.Show();
        }

        private void btVideo3_Click(object sender, EventArgs e)
        {
            Login login = new Login(3);
            login.Show();
        }

        private void btVideo4_Click(object sender, EventArgs e)
        {
            Login login = new Login(4);
            login.Show();
        }

        private void btVideo5_Click(object sender, EventArgs e)
        {
            Login login = new Login(5);
            login.Show();

        }

        private void btVideo6_Click(object sender, EventArgs e)
        {
            Login login = new Login(6);
            login.Show();
        }

        private void btVideo7_Click(object sender, EventArgs e)
        {
            Login login = new Login(7);
            login.Show();

        }

        private void btVideo8_Click(object sender, EventArgs e)
        {
            Login login = new Login(8);
            login.Show();
        }

        private void btVideo9_Click(object sender, EventArgs e)
        {
            Login login = new Login(9);
            login.Show();
        }

        private void btVideo10_Click(object sender, EventArgs e)
        {
            Login login = new Login(10);
            login.Show();
        }    
    }
}
