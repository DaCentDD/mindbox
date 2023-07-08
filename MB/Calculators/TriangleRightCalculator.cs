using MB.Calculators.Interfaces;
using MB.Models;
using MB.Models.Interfaces;

namespace MB.Calculators;

internal class TriangleRightCalculator : ICalculator
{
    private readonly TriangleParameter _triangleParameter;
    private double FirstLeg => _triangleParameter.FirstLeg;
    private double SecondLeg => _triangleParameter.SecondLeg;

    public TriangleRightCalculator(TriangleParameter triangleParameter)
    {
        _triangleParameter = triangleParameter;
    }

    public double Calculate()
    {
        return (FirstLeg * SecondLeg) / 2;
    }
}