

namespace Lotto_Zahlen
{
    public partial class Form1 : Form
    {
        private readonly Random rnd = new Random(Guid.NewGuid().GetHashCode());

        private TextBox[] textBoxTipp = new TextBox[6];

        private void InitializeTextBoxTipp()
        {
            const int textBoxWidth = 50;
            const int textBoxHeight = 20;
            const int gap = 10;
            const int startX = 100;
            const int startY = 200;

            // Loop to create TextBoxes
            for (int i = 0; i < 6; i++)
            {
                TextBox textBox = new TextBox();
                textBox.Location = new Point(startX + (textBoxWidth + gap) * i, startY);
                textBox.Size = new Size(textBoxWidth, textBoxHeight);
                textBox.Name = $"textBox_{i + 1}";
                textBox.Visible = true;
                this.Controls.Add(textBox);
                textBoxTipp[i] = textBox;
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxTipp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBoxTipp[0].Text);
        }

        private int GenerateNumber()
        {
            int number = rnd.Next(1, 49);
            return number;
        }
    }
}