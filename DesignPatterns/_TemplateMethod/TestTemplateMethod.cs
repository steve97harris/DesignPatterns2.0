namespace DesignPatterns._TemplateMethod
{
    public class TestTemplateMethod
    {
        static void Main()
        {
            DataProcessor objectA = new ExcelFile();
            objectA.ReadProcessSave();
            // objectA.ReadData();
            // objectA.ProcessData();
            // objectA.SaveData();
            
            DataProcessor objectB = new TextFile();
            objectB.ReadProcessSave();
            // objectB.ReadData();
            // objectB.ProcessData();
            // objectB.SaveData();
        }
    }
}