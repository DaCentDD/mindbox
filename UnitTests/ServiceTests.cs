using MB;
using MB.Calculators;
using MB.Interfaces;
using MB.Models;
using Moq;

namespace UnitTests;

public class ServiceTests
{ 
    [Test]
    [TestCase(5, 78.54)]
    public void TestCircleSquare(double radius, double expected)
    {
        var calculatorFactory = new Mock<ICalculatorFactory>();
        calculatorFactory
            .Setup(f => f.GetCalculator(It.IsAny<CircleParameter>()))
            .Returns<CircleParameter>(p => new CircleCalculator(p));
        
        var squareService = new Square(calculatorFactory.Object);
        var parameter = new CircleParameter(radius);
        var result = squareService.Calculate(parameter);
        Assert.AreEqual(expected, Math.Round(result, 2));
    }

    [Test]
    [TestCase(2, 3, 4, 2.90)]
    public void TestTriangleSquare(double firstLeg, double secondLeg, double hypotenuse, double expected)
    {
        var calculatorFactory = new Mock<ICalculatorFactory>();
        calculatorFactory
            .Setup(f => f.GetCalculator(It.IsAny<TriangleParameter>()))
            .Returns<TriangleParameter>(p => new TriangleCalculator(p));
        
        var squareService = new Square(calculatorFactory.Object);
        var parameter = new TriangleParameter(firstLeg, secondLeg, hypotenuse);
        var result = squareService.Calculate(parameter);
        Assert.AreEqual(expected, Math.Round(result, 2));
    }
    
    [Test]
    [TestCase(8.3, 12.4, 14.92, 51.46)]
    public void TestRightTriangleSquare(double firstLeg, double secondLeg, double hypotenuse, double expected)
    {
        var calculatorFactory = new Mock<ICalculatorFactory>();
        calculatorFactory
            .Setup(f => f.GetCalculator(It.IsAny<TriangleParameter>()))
            .Returns<TriangleParameter>(p => new TriangleRightCalculator(p));
        
        var squareService = new Square(calculatorFactory.Object);
        var parameter = new TriangleParameter(firstLeg, secondLeg, hypotenuse);
        var result = squareService.Calculate(parameter);
        Assert.AreEqual(expected, Math.Round(result, 2));
    }
}