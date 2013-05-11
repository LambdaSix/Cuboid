namespace Cuboid.Common.NoiseGenerators
{
    public interface IPerlinNoise2D
    {
        float Amplitude { get; set; }
        float Frequency { get; set; }

        double GetInterpolatedPoint(int xA, int xB, int yA, int yB, double x, double y);
        double Interpolate(double a, double b, double x);
    }
}