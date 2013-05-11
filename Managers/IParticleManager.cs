using System.Collections.Generic;
using Cuboid.Particles;
using Microsoft.Xna.Framework;

namespace Cuboid.Managers
{
    public interface IParticleEmitter
    {
        Vector3 PreviousPosition { get; set; }
        Vector3 Position { get; set; }

        void Update(GameTime gameTime, Vector3 newPosition);
    }

    public interface IParticleManager : IManager
    {
        // TODO: Documentation.

        IList<IParticleSystem> ParticleSystems { get; set; }
        IList<IParticleEmitter> ParticleEmitters { get; set; }

        void Draw(GameTime gameTime);
    }
}