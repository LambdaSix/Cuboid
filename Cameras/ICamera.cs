using Microsoft.Xna.Framework;

namespace Cuboid.Cameras
{
    public interface ICamera
    {
        // TODO: Documentation.

        ICuboidGame Game { get; }
        Matrix View { get; }
        Matrix Projection { get; }
        Vector3 Position { get; }

        void CalculateProjection();
        void CalculateView();
        void Initialize();
        void Update(GameTime gameTime);
    }
}