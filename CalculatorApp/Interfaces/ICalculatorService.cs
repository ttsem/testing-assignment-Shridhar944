// Orchestrator — combines calculation + history
public interface ICalculatorService
{
    double Calculate(string operation, double a, double b);
    IReadOnlyList<CalculationRecord> GetHistory();
    void ClearHistory();
}