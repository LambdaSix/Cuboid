using Cuboid.Blocks;

namespace Cuboid.WorldEngine.Generators
{
    public interface IMapGenerator
    {
        IBlockType[,,] GenerateMap();
    }
}