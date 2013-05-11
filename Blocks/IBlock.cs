namespace Cuboid.Blocks
{
    public interface IBlock
    {
        IBlockType Type { get; set; }
        byte FaceInfo { get; set; }
    }
}