using System;
using Cuboid.Common;
using Microsoft.Xna.Framework;

namespace Cuboid.Managers
{
    public interface IStateManager : IManager
    {
        // TODO: Documentation.

        IState ActiveState { get; set; }

        IState GetState(Type type);
        void ProcessInput(GameTime gameTime);
        void Draw(GameTime gameTime);
    }
}