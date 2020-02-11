namespace DesignPatterns._TemplateMethod
{
    public class TestTemplateMethod
    {
        static void Main()
        {
            ExcelFile objectA = new ExcelFile();
            objectA.ReadData();
            objectA.ProcessData();
            objectA.SaveData();
            
            TextFile objectB = new TextFile();
            objectB.ReadData();
            objectB.ProcessData();
            objectB.SaveData();
        }
    }
}