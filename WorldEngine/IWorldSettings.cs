using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Cuboid.WorldEngine
{
    public interface IWorldSettings
    {
        // TODO: Documentation

        float TextureSize { get; set; }

        int SeedValue { get; set; }

        int MapWidth { get; set; }
        int MapHeight { get; set; }
        int MapLength { get; set; }

        int RegionWidth { get; set; }
        int RegionHeight { get; set; }
        int RegionLength { get; set; }

        int SnowLine { get; set; }
        int SeaLevel { get; set; }
        int FogNear { get; set; }
        int FogFar { get; set; }
        int FarPlane { get; set; }

        byte MaxLight { get; set; }
        byte MinLight { get; set; }

        float SideShadows { get; set; }

        int WaterFlowDistance { get; set; }
        int LavaFlowDistance { get; set; }
        int WaterSleepTime { get; set; }

        int MaxProjectiles { get; set; }
        float ProjectileGravity { get; set; }

        float PlayerGravity { get; set; }
        float PlayerMoveSpeed { get; set; }
        float PlayerJumpVelocity { get; set; }
        float PlayerSwimVelocity { get; set; }

        int TextureAtlasSize { get; set; }

        string LevelFolder { get; set; }

        VertexDeclaration VertexDeclaration { get; set; }
        Texture2D TextureSet { get; set; }

        Vector2 GetTextureCoords(int x, int y);
    }
}