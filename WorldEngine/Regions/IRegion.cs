using Cuboid.Blocks;
using Cuboid.Common;
using Cuboid.VertexFormats;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Cuboid.WorldEngine.Regions
{
    public interface IRegion
    {
        IRegionManager RegionManager { get; set; }
        bool IsModified { get; set; }
        bool IsDirty { get; set; }
        int NodeIndex { get; set; }
        BoundingBox BoundingBox { get; set; }
        Vector3i Position { get; set; }

        VertexBuffer SolidVertexBuffer { get; set; }
        VertexBuffer ModelVertexBuffer { get; set; }
        VertexBuffer WaterVertexBuffer { get; set; }


        void BuildVertexBuffers();

        void BuildBlockVertices(VertexPositionTextureShade[] vertexArray, VertexBufferType vertexBufferType, IBlockType blockType, byte faceInfo,
                                Vector3i position);

        void BuildFaceVertices(Vector3i position, VertexBufferType buffer, ref VertexPositionTextureShade[] vertexArray,
                               BlockFaceDirection faceDir, IBlockTexture texture);

        VertexPositionTextureShade BuildVertex(Vector3 position, Vector2 textureCoords, float shade);

        IBlockType BlockAt(Vector3i position);
        byte FacesAt(Vector3i position);

        void AddBlock(Vector3i position, IBlockType blockType);
        IBlockType RemoveBlock(Vector3i position);

        void AddWaterFace(Vector3i position, BlockFaceDirection face);
        void RemoveWaterFace(Vector3i position, BlockFaceDirection face);

        void AddModelFace(Vector3i position, BlockFaceDirection face);
        void RemoveModelFace(int x, int y, int z, BlockFaceDirection face);

        void AddSolidFace(Vector3i position, BlockFaceDirection face);
        void RemoveSolidFace(Vector3i position, BlockFaceDirection face);

        void SetBlockFaces(IBlockType blockType, Vector3i b, IBlockType neighbourType, Vector3i n,
                           BlockFaceDirection bFace, BlockFaceDirection nFace);

        void BuildUVMappings();
        Vector2[] GetUVMapping(int texture, BlockFaceDirection face);

        void Build();
        void Clear();
        void InitializeRegion();
    }
}