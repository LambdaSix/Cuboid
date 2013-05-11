using Microsoft.Xna.Framework;

namespace Cuboid.Components
{
    public interface IComponent
    {
        // TODO: Documentation.

        void Initialize();
        void LoadContent();
        void Update(GameTime gameTime);
        void Draw(GameTime gameTime);
    }
}