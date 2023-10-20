using System.Windows.Forms;

namespace LagerPlatz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button_Status_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (pictureBox_Platz1.BackColor == Color.Green)
                    {
                        pictureBox_Platz1.BackColor = Color.Yellow;
                    }
                    else
                    {
                        pictureBox_Platz1.BackColor = Color.Green;
                    }
                    break;

                case 1:
                    if (pictureBox_Platz2.BackColor == Color.Green)
                    {
                        pictureBox_Platz2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        pictureBox_Platz2.BackColor = Color.Green;
                    }
                    break;

                case 2:
                    if (pictureBox_Platz3.BackColor == Color.Green)
                    {
                        pictureBox_Platz3.BackColor = Color.Yellow;
                    }
                    else
                    {
                        pictureBox_Platz3.BackColor = Color.Green;
                    }
                    break;
            }
        }
    }
}