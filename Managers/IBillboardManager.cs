using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Cuboid.Managers
{
    // TODO: Documentation.

    public interface IBillboardManager : IManager
    {
        VertexDeclaration VertexDeclaration { get; set; }
        VertexPositionTexture QuadVertices { get; set; }
    }

    public interface IBillboardContainer
    {
        VertexBuffer VertexBuffer { get; set; }
        BoundingSphere BoundingSphere { get; set; }
        Texture2D Texture { get; set; }
        IList<VertexPositionNormalTexture> Vertices { get; set; }
    }
}