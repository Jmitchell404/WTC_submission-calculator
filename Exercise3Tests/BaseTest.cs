using Calculators;

namespace Exercise3Tests;

[QaVerification.Grading]
[TestFixture]
public class BaseTest
{
  protected SimpleCalculator calculator;
    [SetUp] public void Init()
    {
      TestContext.WriteLine("Maybe");
      calculator = new SimpleCalculator().Enter(4);
    }

    [TearDown] public void Cleanup()
    { 
      TestContext.WriteLine("Working!!");
      calculator.Reset(); 
    }
}