using Calculators;

namespace Exercise4Tests;
public class CalculatorFactory
{
    protected SimpleCalculator calculator = null!;
    public SimpleCalculator CreateWithInitialStateOf(decimal initialState)
    {   calculator = new SimpleCalculator();
        calculator.Enter(initialState);
        return calculator;
    }
}    