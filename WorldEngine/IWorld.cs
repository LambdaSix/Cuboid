using Cuboid.Blocks;
using Cuboid.Common;
using Cuboid.Rendering;
using Cuboid.WorldEngine.Regions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Cuboid.WorldEngine
{
    public interface IWorld
    {
        VertexDeclaration VertexDeclaration { get; }
        int RegionsDrawn { get; }
        ICuboidGame Game { get; }
        ILighting Lighting { get; }
        void Initialize();
        void BuildRegions(IRegionBuilder builder);
        void BuildRegions();
        void Update(GameTime gameTime);
        void Draw(GameTime gameTime, bool underWater);
        void RemoveBlock(int x, int y, int z);
        void AddBlock(int x, int y, int z, IBlockType blockType);
        void AddBlock(int x, int y, int z, IBlockType blockType, bool calcShadows, bool flow);
        IBlockType BlockAtPoint(Vector3 position);
        IBlockType BlockAt(int x, int y, int z);
        void AddWaterFace(int x, int y, int z, BlockFaceDirection face);
        void RemoveWaterFace(int x, int y, int z, BlockFaceDirection face);
        void AddSolidFace(int x, int y, int z, BlockFaceDirection face);
        void RemoveSolidFace(int x, int y, int z, BlockFaceDirection face);
        void AddModelFace(int x, int y, int z, BlockFaceDirection face);
        void RemoveModelFace(int x, int y, int z, BlockFaceDirection face);
        bool SolidAtPoint(Vector3 position);
        bool SolidAt(int x, int y, int z);
        void MakeDirty(int x, int y, int z);
        bool InWorldBounds(int x, int y, int z);
    }
}