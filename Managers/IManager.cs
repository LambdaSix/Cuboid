using Microsoft.Xna.Framework;

namespace Cuboid.Managers
{
    public interface IManager
    {
        ICuboidGame Game { get; set; }
        void Initialize();
        void LoadContent();
        void Update(GameTime gameTime);
    }
}