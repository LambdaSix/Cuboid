namespace Cuboid.Blocks
{
    public interface IBlockType
    {
        int Cost { get;  }
        bool IsSolidBlock { get;  }
        bool IsLightEmittingBlock { get;  }
        bool IsLightTransparentBlock { get;  }
        bool IsDiggable { get;  }
        bool IsModelBlock { get;  }
        bool IsWater { get;  }


        int GetId();
        IBlockTexture GetTexture();
    }

    public interface IBlockTypes
    {
        IBlockType GetBlockType<T>();
    }

    public interface IBlockTexture
    {
        int GetTexture();
    }
}