using MB;
using MB.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace IntegrationTests;

public class Tests
{
    private ISquare _squareService;

    [OneTimeSetUp]
    public void Setup()
    {
        var application = new WebApplicationFactory<Program>();
        using var scope = application.Services.CreateScope();
        _squareService = scope.ServiceProvider.GetRequiredService<ISquare>();
    }
    
    [Test]
    [TestCase(5, 78.54)]
    [TestCase(0, 0)]
    public void TestCircleSquare(double radius, double expected)
    {
        var result = _squareService.Calculate(new CircleParameter(radius));
        Assert.AreEqual(expected, Math.Round(result, 2));
    }
    
    [Test]
    [TestCase(2, 3, 4, 2.90)]
    public void TestTriangleSquare(double firstLeg, double secondLeg, double hypotenuse, double expected)
    {
        var result = _squareService.Calculate(new TriangleParameter(firstLeg, secondLeg, hypotenuse));
        Assert.AreEqual(expected, Math.Round(result, 2));
    }
}