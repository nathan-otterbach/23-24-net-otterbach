namespace Rolltor
{
    public partial class Form1 : Form
    {
        private bool b1 = true;
        private bool b2 = false;
        private bool m1 = false;

        // deauflt --> 0, up --> 1, down --> 2, stop --> 3
        private uint zustand = 0;

        public Form1()
        {
            InitializeComponent();
            move(zustand);
        }

        private void button_up_Click(object sender, EventArgs e)
        { 
            zustand = 1;
            move(zustand);
        }

        private void button_down_Click(object sender, EventArgs e)
        {
            zustand = 2;
            move(zustand);
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            zustand = 3;
            move(zustand);
        }

        private void move (uint zustand) {             
            switch (zustand)
            {
                case 0:
                    pictureBox_m1.BackColor = Color.Red;
                    pictureBox_b1.BackColor = Color.Green;
                    pictureBox_b2.BackColor = Color.Red;
                    break;
                case 1:
                    if (b2 && b1)
                    {
                        m1 = true;
                        pictureBox_m1.BackColor = Color.Green;
                        for (int i = pictureBox_rolltor.Size.Height; i > 50; i--)
                        {
                            pictureBox_rolltor.Size = new Size(pictureBox_rolltor.Size.Width, pictureBox_rolltor.Size.Height - 1);
                        }
                    }
                    break;
                case 2:
                    if (b1 || !b2)
                    {
                        m1 = true;
                        zustand = 1;
                    }
                    break;
                case 3:
                    if (b1 && !b2)
                    {
                        m1 = true;
                        zustand = 1;
                    }
                    else if (!b1 && b2)
                    {
                        m1 = false;
                        zustand = 2;
                    }
                    break;
            }
        }
    }
}
