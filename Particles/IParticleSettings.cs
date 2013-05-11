using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Cuboid.Particles
{
    /// <summary>
    /// Settings class for Particle effects.
    /// </summary>
    public interface IParticleSettings
    {
        /// <summary>
        /// Name of the texture used by this particle system.
        /// </summary>
        string TextureName { get; set; }

        /// <summary>
        /// Maximum number of particles to be rendered.
        /// </summary>
        int MaxParticles { get; set; }

        /// <summary>
        /// How long will these particles last for?
        /// </summary>
        TimeSpan Lifespan { get; set; }

        /// <summary>
        /// If >0, some particles will last a shorter or longer amount of time.
        /// </summary>
        float LifeEntropy { get; set; }

        /// <summary>
        /// Controls the degree to which particles are influenced by the velocity
        /// of the creating object.
        /// </summary>
        float EmitterVelocitySensitivity { get; set; }

        /// <summary>
        /// Range of values controlling how much of a horizontal velocity to give
        /// newly spawned particles.
        /// </summary>
        float MinHorizontalVelocity { get; set; }
        float MaxHorizontalVelocity { get; set; }

        /// <summary>
        /// Range of values controlling how much of a vertical velocity to give
        /// newly spawned particles.
        /// </summary>
        float MinVerticalVelocity { get; set; }
        float MaxVerticalVelocity { get; set; }

        /// <summary>
        /// Direction and strength of the effect of gravity.
        /// <remarks>
        /// Can point in any direction, e.g. Upwards on torches to simulate smoke.
        /// </remarks>
        /// </summary>
        Vector3 Gravity { get; set; }

        /// <summary>
        /// Controls how the particle velocity changes over time.
        /// At 1.0, particles will continue at the same speed as when created.
        /// At 0, particles will come to a stop before they die.
        /// For values larger than 1.0, particles speed up over time.
        /// </summary>
        float EndVelocity { get; set; }

        /// <summary>
        /// Range of values controlling the particle colour and alpha.
        /// Individual particles are chosen randomly within these limits.
        /// </summary>
        Color MinColour { get; set; }
        Color MaxColour { get; set; }

        /// <summary>
        /// Range of values controlling the speed of particle rotation.
        /// </summary>
        float MinRotationSpeed { get; set; }
        float MaxRotationSpeed { get; set; }

        /// <summary>
        /// Range of values controlling how big particles are when first created.
        /// </summary>
        float MinStartSize { get; set; }
        float MaxStartSize { get; set; }

        /// <summary>
        /// Range of values controlling how big particles are at the end of their life.
        /// </summary>
        float MinEndSize { get; set; }
        float MaxEndSize { get; set; }

        BlendState BlendState { get; set; }
    }
}