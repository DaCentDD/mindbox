using MB.Models.Interfaces;

namespace MB.Models;

public class CircleParameter : ISquareParameter
{
    public CircleParameter(double radius)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius));
        
        Radius = radius;
    }
    
    public double Radius { get; }
}