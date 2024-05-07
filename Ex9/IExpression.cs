namespace Ex9
{
    // Интерфейс для всех узлов (компонентов)
    public interface IExpression
    {
        bool Evaluate();
        void PrintTree(int indent = 0);
    }
}
