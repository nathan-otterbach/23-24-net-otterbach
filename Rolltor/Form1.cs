using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rolltor
{
    public partial class Form1 : Form
    {
        private bool up = false;
        private bool down = false;

        // default --> 0, up --> 1, down --> 2, stop --> 3
        private uint zustand = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void button_up_Click(object sender, EventArgs e)
        {
            zustand = 1;
            up = true;
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            zustand = 2;
            down = true;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            zustand = 3;
            up = false;
            down = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (zustand)
            {
                // default
                case 0:
                    pictureBox_m1.BackColor = Color.Red;
                    pictureBox_b1.BackColor = Color.Green;
                    pictureBox_b2.BackColor = Color.Red;
                    break;

                // up
                case 1:
                    if (up)
                    {
                        pictureBox_m1.BackColor = Color.Green;

                        if (pictureBox_rolltor.Height > 50)
                        {
                            pictureBox_rolltor.Height -= 2;
                        }

                        if (pictureBox_rolltor.Height <= pictureBox_b2.Location.Y)
                        {
                            pictureBox_b2.BackColor = Color.Red;
                        }
                    }
                    break;

                // down
                case 2:
                    if (down)
                    {
                        pictureBox_m1.BackColor = Color.Green;

                        if (pictureBox_rolltor.Height < ClientSize.Height - 110)
                        {
                            pictureBox_rolltor.Height += 2;
                        }
                        else
                        {
                            pictureBox_b2.BackColor = Color.Green;
                        }
                    }
                    break;

                // stop
                case 3:
                    pictureBox_m1.BackColor = Color.Red;
                    break;
            }
        }
    }
}