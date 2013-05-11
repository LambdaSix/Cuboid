using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;

namespace Cuboid.Particles
{
    // HACK: Not an interface, but required.

    /// <summary>
    /// Custom Vertex structure for drawing Particles.
    /// </summary>
    public struct ParticleVertex
    {
        /// <summary>
        /// Which corner of this particle quad this vertex stores.
        /// </summary>
        public Short2 Corner;

        /// <summary>
        /// Starting position of the particle
        /// </summary>
        public Vector3 Position;

        /// <summary>
        /// Starting velocity of the particle.
        /// </summary>
        public Vector3 Velocity;

        /// <summary>
        /// Four random values to make each particle look different slightly.
        /// </summary>
        public Color Random;

        /// <summary>
        /// The time (in seconds) that this particle spawned.
        /// </summary>
        public float Time;

        public static readonly VertexDeclaration VertexDeclaration = new VertexDeclaration(
            new VertexElement(0, VertexElementFormat.Short2,
                VertexElementUsage.Position, 0),

            new VertexElement(4, VertexElementFormat.Vector3, 
                VertexElementUsage.Position, 1),

            new VertexElement(16, VertexElementFormat.Vector3, 
                VertexElementUsage.Normal, 0),

            new VertexElement(28, VertexElementFormat.Color, 
                VertexElementUsage.Color, 0),

            new VertexElement(32, VertexElementFormat.Single, 
                VertexElementUsage.TextureCoordinate, 0)
            );

        public const int SizeInBytes = 36;
    }
}