using Microsoft.Xna.Framework;

namespace Cuboid.Rendering
{
    public interface ICubeRenderer
    {
        void LoadContent();
        void AddCube(Vector3 position, float size, Color colour);
        void Clear();
        void Build();
        void Draw(GameTime gameTime);
    }
}