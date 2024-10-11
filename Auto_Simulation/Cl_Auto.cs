
namespace Auto_Simulation
{
    public class Cl_Auto
    {
        private Color _color_base;
        private Color _color_wheel;
        private Color _color_window;
        private int _groeße;
        private int _x;
        private int _y;
        private int _geschwindigkeit;

        public Cl_Auto() { }

        public Cl_Auto(Color color_base, Color color_wheel, Color color_window, int groeße, int x, int y, int geschwindigkeit)
        {
            Color_Base = color_base;
            Color_Wheel = color_wheel;
            Color_Window = color_window;
            Groeße = groeße;
            X = x;
            Y = y;
            Geschwindigkeit = geschwindigkeit;
        }

        public Color Color_Base
        {
            get { return _color_base; }
            set { _color_base = value; }
        }

        public Color Color_Wheel
        {
            get { return _color_wheel; }
            set { _color_wheel = value; }
        }

        public Color Color_Window
        {
            get { return _color_window; }
            set { _color_window = value; }
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

        public int Geschwindigkeit
        {
            get { return _geschwindigkeit; }
            set { _geschwindigkeit = value; }
        }

        public void Draw(Graphics g)
        {
            
            g.FillRectangle(new SolidBrush(Color_Base), X, Y, Groeße, Groeße / 2);
            g.FillRectangle(new SolidBrush(Color_Window), X + Groeße / 2, Y + Groeße / 10, Groeße / 5, Groeße / 5);

            g.FillEllipse(new SolidBrush(Color_Wheel), X + Groeße / 10, Y + Groeße / 2, Groeße / 5, Groeße / 5);
            g.FillEllipse(new SolidBrush(Color_Wheel), X + Groeße - Groeße / 5 - Groeße / 10, Y + Groeße / 2, Groeße / 5, Groeße / 5);
        }
    }
}
