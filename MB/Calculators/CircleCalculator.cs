using MB.Calculators.Interfaces;
using MB.Models;

namespace MB.Calculators;

internal class CircleCalculator : ICalculator
{
    private readonly CircleParameter _circleParameter;

    public CircleCalculator(CircleParameter circleParameter)
    {
        _circleParameter = circleParameter;
    }

    public double Calculate()
    {
        return Math.PI * Math.Pow(_circleParameter.Radius, 2);
    }
}