namespace Cuboid.Common.NoiseGenerators
{
    public interface IPerlinSimplexNoise
    {
        float Noise(float xIn, float yIn, float zIn);
        float Noise(float xIn, float yIn);
    }
}