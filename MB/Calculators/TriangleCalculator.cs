using MB.Calculators.Interfaces;
using MB.Models;
using MB.Models.Interfaces;

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
        if (IsTriangleRight())
        {
            return (FirstLeg * SecondLeg) / 2;
        }

        var halfPerimeter = (FirstLeg + SecondLeg + Hypotenuse) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstLeg) * (halfPerimeter - SecondLeg) * (halfPerimeter - Hypotenuse));
    }

    private bool IsTriangleRight()
    {
        var hypotenuseSquared = Math.Round(Math.Pow(Hypotenuse, 2));
        var firstLegSquared = Math.Round(Math.Pow(FirstLeg, 2));
        var secondLegSquared = Math.Round(Math.Pow(SecondLeg, 2));

        return Math.Abs(firstLegSquared + secondLegSquared - hypotenuseSquared) < double.Epsilon;
    }
}