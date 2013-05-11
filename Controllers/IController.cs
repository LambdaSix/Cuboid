using Microsoft.Xna.Framework;

namespace Cuboid.Controllers
{
    public interface IController
    {
        ICuboidGame Game { get; }

        void Initialize();
        void Update(GameTime gameTime);
    }
}