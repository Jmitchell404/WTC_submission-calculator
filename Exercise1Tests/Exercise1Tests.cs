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
}