using DesignPatterns._singletons;

namespace DesignPatterns._03_Behavioral._11_TemplateMethod.Builder
{
    public abstract class Builder
    {
        public abstract void CompileCode();
        public abstract void Test();
        public abstract void BugFixes();
        public abstract void Assemble();
        public abstract void Deploy();
        
        public void Build()
        {
            CompileCode();
            Test();
            BugFixes();
            Assemble();
            Deploy();
        }
    }
}