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
        public Boolean flag=true;

        public Home()
        {
            InitializeComponent();
        }

        /*player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer_PlayStateChange);

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Test the current state of the player and display a message for each state.
            switch (e.newState)
            {
                case 0:    // Undefined
                    currentStateLabel.Text = "Undefined";
                    break;

                case 1:    // Stopped
                    currentStateLabel.Text = "Stopped";
                    break;

                case 2:    // Paused
                    currentStateLabel.Text = "Paused";
                    break;

                case 3:    // Playing
                    currentStateLabel.Text = "Playing";
                    break;

                case 4:    // ScanForward
                    currentStateLabel.Text = "ScanForward";
                    break;

                case 5:    // ScanReverse
                    currentStateLabel.Text = "ScanReverse";
                    break;

                case 6:    // Buffering
                    currentStateLabel.Text = "Buffering";
                    break;

                case 7:    // Waiting
                    currentStateLabel.Text = "Waiting";
                    break;

                case 8:    // MediaEnded
                    currentStateLabel.Text = "MediaEnded";
                    break;

                case 9:    // Transitioning
                    currentStateLabel.Text = "Transitioning";
                    break;

                case 10:   // Ready
                    currentStateLabel.Text = "Ready";
                    break;

                case 11:   // Reconnecting
                    currentStateLabel.Text = "Reconnecting";
                    break;

                case 12:   // Last
                    currentStateLabel.Text = "Last";
                    break;

                default:
                    currentStateLabel.Text = ("Unknown State: " + e.newState.ToString());
                    break;
            }
        }*/
        private void btVideo1_Click(object sender, EventArgs e)
        {
            Login login = new Login(1);
            login.ShowDialog();

        }

        private void btVideo2_Click(object sender, EventArgs e)
        {
            Login login = new Login(2);
            login.ShowDialog();
        }

        private void btVideo3_Click(object sender, EventArgs e)
        {
            Login login = new Login(3);
            login.ShowDialog();
        }

        private void btVideo4_Click(object sender, EventArgs e)
        {
            Login login = new Login(4);
            login.ShowDialog();
        }

        private void btVideo5_Click(object sender, EventArgs e)
        {
            Login login = new Login(5);
            login.ShowDialog();

        }

        private void btVideo6_Click(object sender, EventArgs e)
        {
            Login login = new Login(6);
            login.ShowDialog();
        }

        private void btVideo7_Click(object sender, EventArgs e)
        {
            Login login = new Login(7);
            login.ShowDialog();

        }

        private void btVideo8_Click(object sender, EventArgs e)
        {
            Login login = new Login(8);
            login.ShowDialog();
        }

        private void btVideo9_Click(object sender, EventArgs e)
        {
            Login login = new Login(9);
            login.ShowDialog();
        }

        private void btVideo10_Click(object sender, EventArgs e)
        {
            Login login = new Login(10);
            login.ShowDialog();
        }


        public void btInvisible()
        {
            btVideo1.Visible = false;
            btVideo2.Visible = false;
            btVideo3.Visible = false;
            btVideo4.Visible = false;
            btVideo5.Visible = false;
            btVideo6.Visible = false;
            btVideo7.Visible = false;
            btVideo8.Visible = false;
        }

        
   








    }
}
