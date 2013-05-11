using Cuboid.Common;
using Microsoft.Xna.Framework;

namespace Cuboid.WorldEngine.Regions
{
    public interface IRegionCache
    {
        Vector3 PlayerPosition { get; set; }

        void Clear();
        void Flush(Vector3 playerPosition, float radius);
        void Save();
        IRegion FindRegion(Vector3i regionPosition);
        void SubmitModifiedRegionsForBuild();
        void QueueBuild(IRegion region);
        void QueueLoad(Vector3i position);
        bool IsLoaded(Vector3i position);

        void DoBuild(IRegion region);
        void DoLoad(Vector3i regionPosition);

        IRegion LoadRegion(Vector3i position);
        IRegion GetRegion(Vector3i position);

        void BuildingThread();
        void LoadingThread();

    }
}