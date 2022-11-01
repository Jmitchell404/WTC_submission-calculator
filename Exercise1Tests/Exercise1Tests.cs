using Calculators;

namespace Exercise1Tests;

[QaVerification.Grading]
public class Exercise1Tests
{
    [Test]
    public void AdditionTest()
    {
        // Arrange
        var calculator = new SimpleCalculator();

        // Act
        var result = calculator.Enter(4).Plus(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void SubtractionTest()
    {
        // Arrange
        var calculator = new SimpleCalculator();

        // Act
        var result = calculator.Enter(4).Minus(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    public void MultiplicationTest()
    {
        // Arrange
        var calculator = new SimpleCalculator();

        // Act
        var result = calculator.Enter(4).MultiplyBy(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void DivisionTest()
    {
        // Arrange
        var calculator = new SimpleCalculator();

        // Act
        var result = calculator.Enter(4).DivideBy(2).Equals();

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}