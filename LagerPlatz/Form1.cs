using System;
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
            // Set the initial selected index of the ComboBox to the first item.
            comboBox1.SelectedIndex = 0;
        }

        // Method to toggle the background color of a PictureBox
        private void TogglePictureBoxColor(PictureBox pictureBox)
        {
            // Check the current color of the PictureBox and toggle it between green and yellow.
            pictureBox.BackColor = (pictureBox.BackColor == Color.Green) ? Color.Yellow : Color.Green;
        }

        private void button_Status_Click(object sender, EventArgs e)
        {
            // Check the selected index of the ComboBox and toggle the color of the corresponding PictureBox.
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    // Toggle the color of pictureBox_Platz1
                    TogglePictureBoxColor(pictureBox_Platz1);
                    break;

                case 1:
                    // Toggle the color of pictureBox_Platz2
                    TogglePictureBoxColor(pictureBox_Platz2);
                    break;

                case 2:
                    // Toggle the color of pictureBox_Platz3
                    TogglePictureBoxColor(pictureBox_Platz3);
                    break;
            }
        }
    }
}