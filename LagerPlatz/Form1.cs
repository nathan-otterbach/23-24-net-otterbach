using System;
using System.Drawing;
using System.Windows.Forms;

namespace LagerPlatz
{
    public partial class Form1 : Form
    {
        private const int Levels = 4;
        private const int BoxesPerLevel = 4;
        private PictureBox[,] pictureBoxes = new PictureBox[Levels, BoxesPerLevel];

        // Enumeration to represent different statuses
        private enum Status
        {
            normal,
            kritisch,
            abgelaufen
        }

        // Create PictureBoxes for all levels and boxes
        private void CreatePictureBoxes()
        {
            const int pictureBoxWidth = 100;
            const int pictureBoxHeight = 80;
            const int gap = 10;
            const int startX = 20; // Fixed X position for "Ebene 1"

            // Loop to create PictureBoxes for each level and box
            for (int i = 0; i < Levels; i++)
            {
                for (int j = 0; j < BoxesPerLevel; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.BackColor = Color.Green; // Set default color
                    pictureBox.Location = new Point(startX + (pictureBoxWidth + gap) * j, 0);
                    pictureBox.Size = new Size(pictureBoxWidth, pictureBoxHeight);
                    pictureBox.Name = $"pictureBox_Ebene{i + 1}_Platz{j + 1}";
                    pictureBox.Visible = false; // Initially hide all PictureBoxes
                    this.Controls.Add(pictureBox);
                    pictureBoxes[i, j] = pictureBox; // Store PictureBox reference in the array
                }
            }
            // Show PictureBoxes for the first level initially
            ShowPictureBoxesForLevel(0);
        }

        // Event handler for level selection change in the ComboBox
        private void ComboBox_Ebene_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_Ebene.SelectedIndex;
            ShowPictureBoxesForLevel(selectedIndex); // Show PictureBoxes for the selected level
        }

        // Show or hide PictureBoxes based on the selected level
        private void ShowPictureBoxesForLevel(int levelIndex)
        {
            for (int i = 0; i < Levels; i++)
            {
                for (int j = 0; j < BoxesPerLevel; j++)
                {
                    pictureBoxes[i, j].Visible = (i == levelIndex);
                }
            }
        }

        // Method to toggle the background color of a PictureBox among green, yellow, and red.
        private void TogglePictureBoxColor(PictureBox pictureBox)
        {
            Status selectedStatus = (Status)comboBox_Status.SelectedIndex;

            int levelIndex = comboBox_Ebene.SelectedIndex;
            int boxIndex = comboBox_Regalnummer.SelectedIndex;

            // Check if indices are within valid bounds
            if (levelIndex >= 0 && levelIndex < Levels && boxIndex >= 0 && boxIndex < BoxesPerLevel)
            {
                // Set PictureBox color based on the selected status
                pictureBox.BackColor = selectedStatus switch
                {
                    Status.normal => Color.Green,
                    Status.kritisch => Color.Yellow,
                    Status.abgelaufen => Color.Red,
                    _ => pictureBox.BackColor,
                };

                statuses[levelIndex, boxIndex] = selectedStatus; // Update the status in the array
            }
        }

        public Form1()
        {
            InitializeComponent();
            CreatePictureBoxes(); // Initialize PictureBoxes
            comboBox_Ebene.SelectedIndex = 0;
            comboBox_Ebene.SelectedIndexChanged += ComboBox_Ebene_SelectedIndexChanged; // Subscribe to ComboBox event
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the initial selected index of the ComboBoxes to the first item.
            comboBox_Ebene.SelectedIndex = 0;
            comboBox_Regalnummer.SelectedIndex = 0;
            comboBox_Status.SelectedIndex = 0;
        }

        // Event handler for the "Status" button click
        private void button_Status_Click(object sender, EventArgs e)
        {
            // Check the selected index of the ComboBox and toggle the color of the corresponding PictureBox.
            int selectedIndex = comboBox_Regalnummer.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < BoxesPerLevel)
            {
                TogglePictureBoxColor(pictureBoxes[comboBox_Ebene.SelectedIndex, selectedIndex]); // Toggle color
            }
        }

        // Event handler for the "kritisch" button click
        private void button_kritisch_Click(object sender, EventArgs e)
        {
            int selectedEbeneIndex = comboBox_Ebene.SelectedIndex;

            // Check if the selected level index is within valid bounds
            if (selectedEbeneIndex >= 0 && selectedEbeneIndex < Levels)
            {
                // Loop through the boxes in the selected level to reset 'kritisch' statuses to 'normal'
                for (int j = 0; j < BoxesPerLevel; j++)
                {
                    if (statuses[selectedEbeneIndex, j] == Status.kritisch)
                    {
                        statuses[selectedEbeneIndex, j] = Status.normal;
                        pictureBoxes[selectedEbeneIndex, j].BackColor = Color.Green; // Reset PictureBox color
                    }
                }
            }
        }
    }
}