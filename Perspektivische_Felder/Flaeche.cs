
namespace Perspektivische_Felder
{
    public abstract class Flaeche
    {
        protected PointF[] _punkte;
        protected int _anzahlPunkte;
        protected readonly Random _rnd = new Random(Guid.NewGuid().GetHashCode());
        protected SolidBrush _farbe = new SolidBrush(Color.Black);

        public abstract void draw(Graphics g);

        public abstract void animate(Graphics g);

        public abstract void delete(Graphics g);
    }
}