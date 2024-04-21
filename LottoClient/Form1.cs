using System;
using System.Linq;
using System.Windows.Forms;

namespace LottoClient
{
    public partial class Form1 : Form
    {
        // Random number generator
        private readonly Random rnd = new Random(Guid.NewGuid().GetHashCode());

        // Arrays to store textboxes and numbers
        private TextBox[] textBoxTipp = new TextBox[6];
        private TextBox[] textBoxZiehung = new TextBox[6];
        private int[] drawnNumbers = new int[6];
        private int[] tippedNumbers = new int[6];

        // Method to initialize textboxes for input
        private void InitializeTextBoxTipp()
        {
            const int textBoxWidth = 50;
            const int textBoxHeight = 20;
            const int gap = 10;
            const int startX = 100;
            const int startY = 100;

            // Loop to create 6 textboxes for input
            for (int i = 0; i < 6; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(startX + (textBoxWidth + gap) * i, startY);
                textBox.Size = new Size(textBoxWidth, textBoxHeight);
                textBox.Name = $"textBox_Tipp_{i + 1}";
                textBox.Visible = true;
                this.Controls.Add(textBox);
                textBoxTipp[i] = textBox; // Store the reference to the textbox in the array
            }
        }

        // Method to initialize textboxes for randomly drawn numbers
        private void InitializeTextBoxZiehung()
        {
            const int textBoxWidth = 50;
            const int textBoxHeight = 20;
            const int gap = 10;
            const int startX = 100;
            const int startY = 150;

            // Loop to create 6 textboxes for displaying drawn numbers
            for (int i = 0; i < 6; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(startX + (textBoxWidth + gap) * i, startY);
                textBox.Size = new Size(textBoxWidth, textBoxHeight);
                textBox.Name = $"textBox_Ziehung_{i + 1}";
                textBox.Visible = true;
                textBox.ReadOnly = true;
                this.Controls.Add(textBox);
                textBoxZiehung[i] = textBox; // Store the reference to the textbox in the array
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxTipp(); // Initialize user input textboxes
            InitializeTextBoxZiehung(); // Initialize textboxes to display drawn numbers
        }

        // Method to generate a random number
        private int GenerateNumber()
        {
            int number = rnd.Next(1, 49);
            int index = -1;

            // Check if the number is already drawn
            if (drawnNumbers.Contains(number))
            {
                for (int i = 0; i < drawnNumbers.Length; i++)
                {
                    if (drawnNumbers[i] == number)
                    {
                        index = i;
                        break;
                    }
                }
            }

            // If the number is already drawn, generate another one
            if (index != -1)
            {
                number = GenerateNumber();
            }
            else // Otherwise, add it to the drawn numbers array
            {
                index = Array.IndexOf(drawnNumbers, 0);
                drawnNumbers[index] = number;
            }

            return number;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Array.Clear(drawnNumbers); // Clear the drawn numbers array

            // Generate and display 6 random numbers
            for (int i = 0; i < 6; i++)
            {
                textBoxZiehung[i].Text = GenerateNumber().ToString();
            }

            GetGuesses(); // Get guesses
            Compare(); // Compare guesses with drawn numbers
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Array.Clear(tippedNumbers); // Clear the guesses

            // Clear all the input textboxes
            for (int i = 0; i < 6; i++)
            {
                textBoxTipp[i].Text = string.Empty;
            }
        }

        private void GetGuesses()
        {
            for (int i = 0; i < 6; i++)
            {
                int tipp;
                // Try to parse the text in the textbox to an integer
                if (!int.TryParse(textBoxTipp[i].Text, out tipp))
                {
                    MessageBox.Show("Invalid input. Please enter valid numbers.");
                    return;
                }
                tippedNumbers[i] = tipp; // Store the user guess
            }
        }

        private void Compare()
        {
            int count = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (tippedNumbers[i] == drawnNumbers[j])
                    {
                        count++; // Increment the count if there's a match
                        break;
                    }
                }
            }

            textBox_Richtige.Text = count.ToString(); // Display the count of correct guesses
        }
    }
}