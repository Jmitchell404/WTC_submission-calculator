using Calculators;

namespace Exercise6Tests;

[QaVerification.Grading]
public class NegativeTestScenarios
{
    protected private readonly SimpleCalculator _calculator = new ();
    [Test]

    public void MaximumAddition()
    {
        var actual = _calculator.Reset().Enter(79228162514264337593543950335.00m);
        Assert.Throws<OverflowException> (() => actual.Plus(1).Equals());
    }
    [Test]
    public void MinimumSubtraction()
    {
        var actual = _calculator.Reset().Enter(-79228162514264337593543950335.00m);
        Assert.Throws<OverflowException> (() => actual.Minus(1).Equals());
    }
     [Test]
    public void DivideByZero()
    {
        var actual = _calculator.Reset().Enter(200);
        Assert.Throws<DivideByZeroException> (() => actual.DivideBy(0).Equals());

    }
}