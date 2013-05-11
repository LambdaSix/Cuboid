using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cuboid.Cameras;
using Cuboid.Common;
using Cuboid.Managers;
using Cuboid.WorldEngine;
using Microsoft.Xna.Framework;

namespace Cuboid
{
    public interface ICuboidGame
    {
        PlayerIndex ActivePlayer { get; set; }
        GraphicsDeviceManager Graphics { get; set; }
        IStateManager StateManager { get; set; }
        IInputState InputState { get; set; }
        ICamera Camera { get; set; }
        IWorldSettings Settings { get; set; }
        ICollection<Thread> Threads { get; set; }
        bool IsActive { get; }
    }
}
