using System;
using System.Collections.Generic;
using System.Text;

namespace VectorMath
{
    public class Vector3
    {
        double X;
        double Y;
        double Z;

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"<{X}, {Y}, {Z}>";
        }
        // Vector Addition
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public void Add(Vector3 other)
        {
            X += other.X;
            Y += other.Y;
            Z += other.Z;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        // Vector Subtraction 
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        // Vector Scaling 
        public static Vector3 operator *(double s, Vector3 b)
        {
            return new Vector3(s * b.X, s * b.Y, s * b.Z);
        }

        public static Vector3 operator *(Vector3 b, double s)
        {
            return new Vector3(s * b.X, s * b.Y, s * b.Z);
        }

        // Vector Comparison
        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return !(a == b); //!(a.X == b.X && a.Y == b.Y && a.Z == b.Z);
        }

        public static readonly Vector3 Zero = new Vector3(0, 0, 0);

        public static bool operator true(Vector3 a)
        {
            return !(a == Zero);
        }
        public static bool operator false(Vector3 a)
        {
            return (a == Zero);
        }
    }
}
