using MB.Calculators.Interfaces;
using MB.Models.Interfaces;

namespace MB.Interfaces;

internal interface ICalculatorFactory
{
    ICalculator GetCalculator(ISquareParameter parameter);
}