using Calculators;

namespace Exercise4Tests;

[QaVerification.Grading]
[TestFixture]
public class Exercise4Tests : CalculatorFactory
{
    private CalculatorFactory deez = new CalculatorFactory();
    [Test]
    public void AdditionTest()
    {
        // Act
        var result = deez.CreateWithInitialStateOf(100).Plus(20).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void SubtractionTest()
    {
        // Act
        var result = deez.CreateWithInitialStateOf(10).Minus(5).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void MultiplicationTest()
    {
        // Act
        var result = deez.CreateWithInitialStateOf(25).MultiplyBy(4).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(100));
    }

    [Test]
    public void DivisionTest()
    {

        // Act
        var result = deez.CreateWithInitialStateOf(33).DivideBy(11).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }
}