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

    public bool IsRight => Math.Abs(Math.Pow(FirstLeg, 2) + Math.Pow(SecondLeg, 2) - Math.Pow(Hypotenuse, 2)) < double.Epsilon;
    
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