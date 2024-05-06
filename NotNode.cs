namespace Ex9
{
    public class NotNode : IExpression
    {
        private IExpression _child;

        public NotNode(IExpression son)
        {
            _child = son;
        }

        public bool Evaluate()
        {
            return !_child.Evaluate();
        }
    }
}
