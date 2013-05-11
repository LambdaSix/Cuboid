using Cuboid.Common;

namespace Cuboid.Rendering
{
    // HACK: Not an interface, but required.

    /// <summary>
    /// Structure for the point origin of a Light Entity.
    /// </summary>
    public struct Light
    {
        public int X;
        public int Y;
        public int Z;
        public byte Intensity;

        public Light(int x, int y, int z, byte intensity) {
            X = x;
            Y = y;
            Z = z;
            Intensity = intensity;
        }

        public Light(Vector3i position, byte intensity) {
            X = position.X;
            Y = position.Y;
            Z = position.Z;
            Intensity = intensity;
        }

    }
}