using System.Collections;
using Calculators;
namespace Exercise6Tests;

[TestFixture]
public class PositiveTestScenarios
{
    private SimpleCalculator Calculator { get; } = new SimpleCalculator();

    [QaVerification.Grading]
    [TestCase(5.0, 7.0, 12.0)]
    [TestCase(2.0, -3.0, -1.0)]
    public void ValuesBasedDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
        var actual = Calculator.Reset().Enter(value1).Plus(value2).Equals();
        Assert.That(actual, Is.EqualTo(expected));
    }

    private static IEnumerable AdditionTestData()
    {
        yield return new TestCaseData(1m, 1m, 2m);
        yield return new TestCaseData(1m, 2m, 3m);
        yield return new TestCaseData(-1m, -1m, -2m);
    }

    [QaVerification.Grading]
    [TestCaseSource(nameof(AdditionTestData))]
    public void GeneratorDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
        var actual = Calculator.Reset().Enter(value1).Plus(value2).Equals();
        Assert.That(actual, Is.EqualTo(expected));
    }
}
