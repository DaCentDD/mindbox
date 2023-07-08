using MB.Models.Interfaces;

namespace MB.Models;

public class TriangleParameter : ISquareParameter
{
    public TriangleParameter(double firstLeg, double secondLeg, double hypotenuse)
    {
        if (firstLeg < 0) throw new ArgumentOutOfRangeException(nameof(firstLeg));
        if (secondLeg < 0) throw new ArgumentOutOfRangeException(nameof(secondLeg));
        if (hypotenuse < 0) throw new ArgumentOutOfRangeException(nameof(hypotenuse));
        
        FirstLeg = firstLeg;
        SecondLeg = secondLeg;
        Hypotenuse = hypotenuse;
    }

    /// <summary>
    /// Первый катет
    /// </summary>
    public double FirstLeg { get; }
    
    /// <summary>
    /// Второй катет
    /// </summary>
    public double SecondLeg { get; }
    
    /// <summary>
    /// Гипотенуза
    /// </summary>
    public double Hypotenuse { get; }
}