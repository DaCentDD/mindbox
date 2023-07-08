using MB.Calculators.Interfaces;
using MB.Models;

namespace MB.Calculators;

internal class TriangleCalculator : ICalculator
{
    private readonly TriangleParameter _triangleParameter;
    private double FirstLeg => _triangleParameter.FirstLeg;
    private double SecondLeg => _triangleParameter.SecondLeg;
    private double Hypotenuse => _triangleParameter.Hypotenuse;

    public TriangleCalculator(TriangleParameter triangleParameter)
    {
        _triangleParameter = triangleParameter;
    }

    public double Calculate()
    {
        var halfPerimeter = (FirstLeg + SecondLeg + Hypotenuse) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstLeg) * (halfPerimeter - SecondLeg) * (halfPerimeter - Hypotenuse));
    }
}