public record CalculationRecord(
    string Operation,      // "Add", "Subtract", "Multiply", "Divide"
    double Operand1,
    double Operand2,
    double Result,
    DateTime Timestamp);