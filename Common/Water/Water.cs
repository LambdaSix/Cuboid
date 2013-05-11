namespace Cuboid.Common.Water
{
    public struct Flow
    {
        public int X;
        public int Y;
        public int Z;
        public int Count;

        public Flow(int x, int y, int z, int count) {
            X = x;
            Y = y;
            Z = z;
            Count = count;
        }

        public Flow(Vector3i position, int count) {
            X = position.X;
            Y = position.Y;
            Z = position.Z;
            Count = count;
        }
    }
}