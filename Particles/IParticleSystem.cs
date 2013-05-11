using Microsoft.Xna.Framework;

namespace Cuboid.Particles
{
    public interface IParticleSystem
    {
        // TODO: Documentation.

        void Initialize();

        /// <summary>
        /// Particle systems should use this method to load tweakable settings.
        /// </summary>
        /// <param name="settings"></param>
        void InitializeSettings(IParticleSettings settings);

        void LoadContent();
        void Update(GameTime gameTime);
        void Draw(GameTime gameTime);

        void LoadParticleEffects();
        void RetireActiveParticles();
        void FreeRetiredParticles();
        void AddNewParticlesToVertexBuffer();

        void SetCamera(Matrix view, Matrix projection);
        void AddParticle(Vector3 position, Vector3 velocity);
    }
}