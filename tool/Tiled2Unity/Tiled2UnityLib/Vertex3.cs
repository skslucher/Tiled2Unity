using System.Drawing;

namespace Tiled2Unity
{
    // Working man's vertex
    public struct Vertex3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public float this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    default:
                        return Z;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        X = value;
                        break;
                    case 1:
                        Y = value;
                        break;
                    default:
                        Z = value;
                        break;
                }
            }
        }

        public static Vertex3 FromPointF(PointF point, float depth)
        {
            return new Vertex3 { X = point.X, Y = point.Y, Z = depth };
        }

        public static Vertex3 Average(Vertex3 v0, Vertex3 v1)
        {
            Vertex3 avg = new Vertex3();

            for (int i = 0; i < 3; i++)
            {
                avg[i] = (v0[i] + v1[i]) * 0.5f;
            }

            return avg;
        }
    }
}
