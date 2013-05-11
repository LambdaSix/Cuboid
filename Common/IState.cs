using Microsoft.Xna.Framework;

namespace Cuboid.Common
{
    public interface IState
    {
        ICuboidGame Game { get; set; }
        void Initialize();
        void LoadContent();
        void ProcessInput(GameTime gameTime);
        void Update(GameTime gameTime);
        void Draw(GameTime gametime);
    }
}