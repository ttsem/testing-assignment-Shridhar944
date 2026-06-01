// History persistence contract — abstracts XML I/O
public interface IHistoryRepository
{
    IReadOnlyList<CalculationRecord> Load();
    void Save(IReadOnlyList<CalculationRecord> records);
}