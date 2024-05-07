namespace Ex9
{
    // Листовой узел с значением
    public class ValueNode : IExpression
    {
        private bool _value;
        public ValueNode(bool value)
        {
            _value = value;
        }
        public bool Evaluate()
        {
            return _value;
        }
        public void PrintTree(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}ValueNode({_value})");
        }
    }
}