namespace Ex9
{
    internal class Program
    {
        static void Main()
        {
            // (true || false) && true
            IExpression exp = new OrNode(
                new AndNode(new ValueNode(true), new ValueNode(false)),   
                new ValueNode(true)
            ); 

            exp.PrintTree();
            //Console.WriteLine(result); // True
        }
    }
}