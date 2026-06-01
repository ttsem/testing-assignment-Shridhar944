// Reads/writes XML file — real I/O
public class XmlHistoryRepository : IHistoryRepository
{
    private readonly string _filePath;
    public XmlHistoryRepository(string filePath) => _filePath = filePath;
    // Serializes/deserializes List<CalculationRecord> to XML
    // Keeps only the last 10 entries on Save()
}