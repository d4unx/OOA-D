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
        public void PrintTree(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}NotNode");
            _child.PrintTree(indent + 2);
        }
    }
}
