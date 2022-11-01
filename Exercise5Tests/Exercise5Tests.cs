using System.Collections;
using Calculators;

namespace Exercise5Tests;

[TestFixture]
public class Exercise5Tests
{
    private SimpleCalculator Calculator { get; } = new();

    [QaVerification.Grading]
    // use the [TestCase] annotation here
    [TestCase(5, 7, 12)]
    [TestCase(2, -3, -1)]
    public void ValuesBasedDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
        SimpleCalculator calculator = Calculator.Enter(value1).Plus(value2);
        Assert.AreEqual(expected, value1 + value2);
        // SimpleCalculator calculator = Calculator.Enter(2).Minus(-3);
        // Assert.AreEqual(decimal expected, decimal value1 + decimal value2);
        // complete this method
    }

    private static IEnumerable AdditionTestData()
    {
        object[] AdditionData =
        {
        new object[] { 1m, 1m, 2m },
        new object[] { 1m, 2m, 3m },
        new object[] { -1m, -2m, -3m },
        };
        return AdditionData; // replace this line with your code
    }

    [QaVerification.Grading]
    // use the [TestCaseSource] annotation here
    [TestCaseSource(nameof(AdditionTestData))]
    public void GeneratorDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
        // complete this method
        SimpleCalculator calculator = Calculator.Enter(value1).Plus(value2);
        Assert.AreEqual(expected, value1 + value2);
    }
}