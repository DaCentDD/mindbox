using MB.Calculators;
using MB.Models;

namespace UnitTests;

public class CalculatorTests
{
    [Test]
    [TestCase(5, 78.54)]
    [TestCase(0, 0)]
    public void TestCircleCalculatorSuccess(double radius, double expected)
    {
        var parameter = new CircleParameter(radius);
        var circleCalculator = new CircleCalculator(parameter);
        var result = circleCalculator.Calculate();
        Assert.AreEqual(expected, Math.Round(result, 2));
    }
    
    [Test]
    [TestCase(-1)]
    public void TestCircleCalculatorError(double radius)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new CircleParameter(radius));
    }
    
    [Test]
    [TestCase(2, 3, 4, 2.90)]
    public void TestTriangleCalculatorSuccess(double firstLeg, double secondLeg, double hypotenuse, double expected)
    {
        var parameter = new TriangleParameter(firstLeg, secondLeg, hypotenuse);
        var circleCalculator = new TriangleCalculator(parameter);
        var result = circleCalculator.Calculate();
        Assert.AreEqual(expected, Math.Round(result, 2));
    }
    
    [Test]
    [TestCase(-1, 2, 3)]
    [TestCase(1, -2, 3)]
    [TestCase(1, 2, -3)]
    public void TestTriangleCalculatorError(double firstLeg, double secondLeg, double hypotenuse)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new TriangleParameter(firstLeg, secondLeg, hypotenuse));
    }
}