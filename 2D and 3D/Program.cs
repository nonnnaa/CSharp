using System;
namespace _2Dand3D
{
    public class _2D
    {
        public float x = 0.0f;
        public float y = 0.0f;
        public _2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float GetX()
        {
            return x;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public float GetY()
        {
            return y;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public float[] GetXY(float x, float y)
        {
            float[] f = new float[] {x, y};
            return f;
        }
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
    public class _3D : _2D
    {
        public float z = 0.0f;
        public _3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public void SetXYZ(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float[] GetXYZ(float x, float y, float z)
        {
            float[] f = new float[] {x, y, z};
            return f;
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
    class Program
    {
        static void Main(string[] s)
        {
            _2D _2dtest = new _2D(1, 2);
            _3D _3dtest = new _3D(1, 2, 3);
            
            Console.WriteLine(_2dtest.ToString());
            Console.WriteLine(_3dtest.ToString());

            Console.WriteLine(_2dtest.GetX());
            Console.WriteLine(_2dtest.GetY());

            Console.WriteLine(_3dtest.GetX());
            Console.WriteLine(_3dtest.GetY());
            Console.WriteLine(_3dtest.GetZ());

            _2dtest.SetX(3);
            _2dtest.SetY(4);

            _3dtest.SetX(4);
            _3dtest.SetY(5);
            _3dtest.SetZ(6);

            _2dtest.GetXY(5, 6);
            _3dtest.SetXYZ(7, 8, 9);

            Console.WriteLine(_2dtest.ToString());
            Console.WriteLine(_3dtest.ToString());
        }
    }
}