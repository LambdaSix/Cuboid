using Microsoft.Xna.Framework;

namespace Cuboid.Particles
{
    public interface IParticle
    {
        // TODO: Documentation.

        Vector3 PreviousPosition { get; set; }
        Vector3 Position { get; set; }

        void Update(GameTime gameTime, Vector3 newPosition);
    }
}