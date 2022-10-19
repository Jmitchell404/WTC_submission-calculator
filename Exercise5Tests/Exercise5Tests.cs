using System.Collections;
using Calculators;

namespace Exercise5Tests;

[TestFixture]
public class Exercise5Tests
{
    private SimpleCalculator Calculator { get; } = new();

    [QaVerification.Grading]
    // use the [TestCase] annotation here
    public void ValuesBasedDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
        // complete this method
    }

    private static IEnumerable AdditionTestData()
    {
        return null; // replace this line with your code
    }

    [QaVerification.Grading]
    // use the [TestCaseSource] annotation here
    public void GeneratorDataDrivenAddition(decimal value1, decimal value2, decimal expected)
    {
        // complete this method
    }
}