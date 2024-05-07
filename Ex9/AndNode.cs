namespace Ex9
{
    // Узел операции "И"
    public class AndNode : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public AndNode(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public bool Evaluate()
        {
            return _left.Evaluate() && _right.Evaluate();
        }
    }
}