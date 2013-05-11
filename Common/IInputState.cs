using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Cuboid.Common
{
    public interface IInputState
    {
        void Update(GameTime gameTime);
        bool IsKeyPressed(Keys key, PlayerIndex? controlIndex, out PlayerIndex activeIndex);
        bool IsKeyDown(Keys key, PlayerIndex? controlIndex, out PlayerIndex activeIndex);
        bool IsButtonPressed(Buttons key, PlayerIndex? controlIndex, out PlayerIndex activeIndex);
        bool IsButtonDown(Buttons key, PlayerIndex? controlIndex, out PlayerIndex activeIndex);
    }
}