using Cuboid.Blocks;

namespace Cuboid.Components
{
    public interface IBlockPicker : IComponent
    {
        // TODO: Documentation.

        IBlockType SelectedBlockType { get; set; }
    }
}