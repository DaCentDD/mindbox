using MB.Interfaces;
using MB.Models.Interfaces;

namespace MB;

internal class Square : ISquare
{
    private readonly ICalculatorFactory _calculatorFactory;

    public Square(ICalculatorFactory calculatorFactory)
    {
        _calculatorFactory = calculatorFactory ?? throw new ArgumentNullException(nameof(calculatorFactory));
    }
    
    public double Calculate(ISquareParameter parameter)
    {
        if (parameter is null)
            throw new ArgumentNullException(nameof(parameter));

        var calculator = _calculatorFactory.GetCalculator(parameter);
        return calculator.Calculate();
    }
}