// Orchestrates calculation + history persistence
public class CalculatorService : ICalculatorService
{
    private readonly ICalculator _calculator;
    private readonly IHistoryRepository _history;
    // Calculate() → compute result → append to history → save → return result
    // GetHistory() → load from repository
    // ClearHistory() → save empty list
}