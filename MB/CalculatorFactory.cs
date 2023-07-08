using MB.Calculators;
using MB.Calculators.Interfaces;
using MB.Interfaces;
using MB.Models;
using MB.Models.Interfaces;

namespace MB;

internal class CalculatorFactory : ICalculatorFactory
{
    public ICalculator GetCalculator(ISquareParameter parameter)
    {
        return parameter switch
        {
            CircleParameter circleParameter => new CircleCalculator(circleParameter),
            TriangleParameter triangleParameter => GetTriangleCalculator(triangleParameter),
            _ => throw new ArgumentOutOfRangeException(nameof(parameter))
        };
    }

    private ICalculator GetTriangleCalculator(TriangleParameter triangleParameter)
    {
        return triangleParameter.IsRight
            ? new TriangleRightCalculator(triangleParameter) 
            : new TriangleCalculator(triangleParameter);
    }
}