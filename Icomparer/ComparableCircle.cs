namespace Shape
{
    public class ComparableCircle : IComparer<Circle>
    {
        public int Compare(Circle x, Circle y)
        {
            if (x.getRadius() > y.getRadius()) return 1;
            if (x.getRadius() < y.getRadius()) return -1;
            return 1;
        }
    }
}