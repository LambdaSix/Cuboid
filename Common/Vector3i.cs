namespace Cuboid.Common
{
    // HACK: Not an interface, but required and common.

    public struct Vector3i
    {
        public Vector3i(int x, int y, int z) {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X;
        public int Y;
        public int Z;

        public override bool Equals(object obj) {
            if (obj is Vector3i)
            {
                Vector3i other = (Vector3i) obj;
                return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
            }
            return base.Equals(obj);
        }

        public static bool operator ==(Vector3i a, Vector3i b) {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Vector3i a, Vector3i b) {
            return !(a.X == b.X && a.Y == b.Y && a.Z == b.Z);
        }

        public override int GetHashCode() {
            int hash = 23;
            unchecked
            {
                hash = hash*37 + X;
                hash = hash*37 + Y;
                hash = hash*37 + Z;
            }
            return hash;
        }

        public override string ToString() {
            return ("vector3i (" + X + "," + Y + "," + Z + ")");
        }

    }
}