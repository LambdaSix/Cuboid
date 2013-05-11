using Cuboid.Blocks;
using Cuboid.Common;

namespace Cuboid.Rendering
{
    public interface ILighting
    {
        void Initialize();
        void Update();

        void BlockAdded(IBlockType blockType, Vector3i position);
        void BlockRemoved(IBlockType blockType, Vector3i position);

        float GetLight(Vector3i position);
    }
}