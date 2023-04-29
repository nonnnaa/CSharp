namespace Shape
{
    public class ComperableCircle : Circle, IComparable<ComperableCircle>
    {
        public ComperableCircle() { }
        public ComperableCircle(double radius) : base(radius) { }
        public ComperableCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

        public int CompareTo(ComperableCircle x)
        {
            if (getRadius() > x.getRadius()) return 1;
            if (getRadius() < x.getRadius()) return -1;
            return 1;
        }
    }
}