namespace Ex9
{
    // Узел операции "ИЛИ"
    public class OrNode : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public OrNode(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public bool Evaluate()
        {
            return _left.Evaluate() || _right.Evaluate();
        }
        public void PrintTree(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}OrNode");
            _left.PrintTree(indent + 2);
            _right.PrintTree(indent + 2);
        }
    }
}
