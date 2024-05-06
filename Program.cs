namespace Ex9
{

    // Интерфейс для всех узлов (компонентов)
    public interface IExpression
    {
        bool Evaluate();
    }

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
    }
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

    internal class Program
    {
        static void Main(string[] args)
        {
            IExpression exp = new OrNode(
                new AndNode(new ValueNode(true), new ValueNode(false)),
                new ValueNode(true)
            );

            bool result = exp.Evaluate();
            Console.WriteLine(result); // True
        }

    }
}
