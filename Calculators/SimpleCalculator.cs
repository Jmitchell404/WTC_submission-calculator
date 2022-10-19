using QaVerification;

namespace Calculators;

[Grading]
public class SimpleCalculator
{
    public SimpleCalculator()
    {
        Reset();
    }

    private decimal LastResult { get; set; }

    public SimpleCalculator Reset()
    {
        LastResult = 0.0M;
        return this;
    }

    public SimpleCalculator Enter(decimal number)
    {
        LastResult = number;
        return this;
    }

    public SimpleCalculator Plus(decimal number)
    {
        LastResult += number;
        return this;
    }

    public SimpleCalculator Minus(decimal number)
    {
        LastResult -= number;
        return this;
    }

    public SimpleCalculator MultiplyBy(decimal number)
    {
        LastResult *= number;
        return this;
    }

    public SimpleCalculator DivideBy(decimal number)
    {
        LastResult /= number;
        return this;
    }

    public decimal Equals()
    {
        return LastResult;
    }
}