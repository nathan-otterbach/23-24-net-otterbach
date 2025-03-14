namespace Vererbung_AnzeigeElement
{
    public class CText : CAnzeigeElement
    {
        private string _text;
        private Font _font;

        public string Text
        {
            get => _text;
            set
            {
                if (value != null) _text = value;
            }
        }

        public Font Font
        {
            get => _font;
            set 
            { 
                if (value != null) _font = value; 
            }
        }

        public CText() : base() { }

        public CText(string text, Font font, int xStart, int yStart, Color farbe)
            : base(0, 0, xStart, yStart, farbe)
        {
            Text = text;
            Font = font;
        }

        public override void draw(Graphics g)
        {
            using (var brush = new SolidBrush(Farbe))
            {
                g.DrawString(Text, Font, brush, XStart, YStart);
            }
        }
    }
}