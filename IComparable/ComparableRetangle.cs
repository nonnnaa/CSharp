namespace Shape
{
    public class ComperableRetangle : Rectangle, IComparable<ComperableCircle>
    {
        public ComperableRetangle() { }
        public ComperableRetangle(double width,double length) : base(width, length) { }
        public ComperableRetangle(double width, double length, string color, bool filled) : base(width, length, color, filled) { }
        public int CompareTo(ComperableCircle x)
        {
            double x1 = getArea();
            double x2 = x.getArea();
            if (x1 > x2) return 1;
            if (x1 < x2) return -1;
            return 0;
        }
    }
}