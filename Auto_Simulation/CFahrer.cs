namespace Auto_Simulation
{
    public class CFahrer
    {
        private Color _color_skin;
        private Color _color_eye;
        private int _groeße;
        private int _x;
        private int _y;

        public CFahrer() { }

        public CFahrer(Color color_skin, Color color_eye, int groeße, int x, int y)
        {
            Color_Skin = color_skin;
            Color_Eye = color_eye;
            Groeße = groeße;
            X = x;
            Y = y;
        }

        public Color Color_Skin
        {
            get { return _color_skin; }
            set { _color_skin = value; }
        }

        public Color Color_Eye
        {
            get { return _color_eye; }
            set { _color_eye = value; }
        }

        public int Groeße
        {
            get { return _groeße; }
            set { _groeße = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public void draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color_Skin), X, Y, Groeße, Groeße);
            g.FillEllipse(new SolidBrush(Color_Eye), X + Groeße / 4, Y + Groeße / 4, Groeße / 4, Groeße / 4);
            g.FillEllipse(new SolidBrush(Color_Eye), X + Groeße / 2, Y + Groeße / 4, Groeße / 4, Groeße / 4);
        }
    }
}