using Cuboid.Common;

namespace Cuboid.WorldEngine.Regions
{
    public interface IRegionManager
    {
        void Flush(bool clear);
        void Load(Vector3i worldPosition);
    }
}