

namespace Lotto_Zahlen
{
    public partial class Form1 : Form
    {
        private readonly Random rnd = new Random(Guid.NewGuid().GetHashCode());

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // iterate through all textboxes and generate a random number
            var textBoxes = GetAllControls<TextBox>(this);
            foreach (TextBox tb in textBoxes)
            {
                tb.Text = GenerateNumber().ToString();
            }
        }

        private int GenerateNumber()
        {
            int number = rnd.Next(1, 49);
            return number;
        }

        // get all controls in form
        public static IList<T> GetAllControls<T>(Control control) where T : Control
        {
            var lst = new List<T>();
            foreach (Control item in control.Controls)
            {
                var ctr = item as T;
                if (ctr != null)
                    lst.Add(ctr);
                else
                    lst.AddRange(GetAllControls<T>(item));
            }
            return lst;
        }
    }
}