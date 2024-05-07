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
    }
}