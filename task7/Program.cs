using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overload7
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString()
        {
            return $@"X : {X}
Y : {Y}
Z : {Z}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Vector vector)
            {
                return this.X == vector.X && this.Y == vector.Y && this.Z == vector.Z;

            }
            return false;
        }

        public static bool operator >(Vector p1, Vector p2)
        {
            return p1.X > p2.X && p1.Y > p2.Y && p1.Z > p2.Z;
        }
        public static bool operator <(Vector p1, Vector p2)
        {
            return p1.X < p2.X && p1.Y < p2.Y && p1.Z < p2.Z;
        }
        public static bool operator >=(Vector p1, Vector p2)
        {
            return p1.X >= p2.X && p1.Y >= p2.Y && p1.Z >= p2.Z;
        }
        public static bool operator <=(Vector p1, Vector p2)
        {
            return p1.X <= p2.X && p1.Y <= p2.Y && p1.Z <= p2.Z;
        }
        public static bool operator ==(Vector p1, Vector p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }
        public static bool operator !=(Vector p1, Vector p2)
        {
            return p1.X != p2.X && p1.Y != p2.Y && p1.Z != p2.Z;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector vector = new Vector()
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y,
                Z = v1.Z + v2.Z
            };
            return vector;
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            Vector vector = new Vector()
            {
                X = v1.X - v2.X,
                Y = v1.Y - v2.Y,
                Z = v1.Z - v2.Z
            };
            return vector;
        }
        public static int operator *(Vector v1, Vector v2)
        {
            Vector vector = new Vector()
            {
                X = v1.X * v2.X,
                Y = v1.Y * v2.Y,
                Z = v1.Z * v2.Z
            };
            return vector.X + vector.Y + vector.Z;
        }
        public static Vector operator /(Vector v1, Vector v2)
        {
            if (v2.X == 0 || v2.Y == 0 || v2.Z == 0)
            {
                throw new DivideByZeroException();
            }

            Vector vector = new Vector()
            {
                X = v1.X * v2.X,
                Y = v1.Y * v2.Y,
                Z = v1.Z * v2.Z
            };
            return vector;
        }
    }
}
