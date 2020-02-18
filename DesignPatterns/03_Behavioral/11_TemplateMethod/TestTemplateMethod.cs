namespace DesignPatterns._TemplateMethod
{
    public class TestTemplateMethod
    {
        static void MainOLD()
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