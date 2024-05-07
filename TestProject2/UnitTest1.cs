using Ex9;
using NUnit.Framework.Interfaces;
namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void ValueNode_Constructor_TrueFalseValue_Returns_Test()
        {
            // Arrange
            bool trueValue = true;
            bool falseValue = false;

            // Act
            var node = new ValueNode(trueValue);

            // Assert
            Assert.IsTrue(node.Evaluate());
            node = new ValueNode(falseValue);
            Assert.IsFalse(node.Evaluate());
        }

        [Test]
        public void AndNode_Evaluate_BothTrue_ReturnsTrue_Test()
        {
            // Arrange
            var left = new ValueNode(true);
            var right = new ValueNode(true);
            var andNode = new AndNode(left, right);

            // Act
            var result = andNode.Evaluate();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void AndNode_Evaluate_LeftFalse_ReturnsFalse_Test()
        {
            // Arrange
            var left = new ValueNode(false);
            var right = new ValueNode(true);
            var andNode = new AndNode(left, right);

            // Act
            var result = andNode.Evaluate();

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void AndNode_Evaluate_RightFalse_ReturnsFalse_Test()
        {
            // Arrange
            var left = new ValueNode(true);
            var right = new ValueNode(false);
            var andNode = new AndNode(left, right);

            // Act
            var result = andNode.Evaluate();

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void AndNode_Evaluate_BothFalse_ReturnsFalse_Test()
        {
            // Arrange
            var left = new ValueNode(false);
            var right = new ValueNode(false);
            var andNode = new AndNode(left, right);

            // Act
            var result = andNode.Evaluate();

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void OrNode_Evaluate_BothTrue_ReturnsTrue_Test()
        {
            // Arrange
            var left = new ValueNode(true);
            var right = new ValueNode(true);
            var orNode = new OrNode(left, right);

            // Act
            var result = orNode.Evaluate();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void OrNode_Evaluate_LeftTrueRightFalse_ReturnsTrue_Test()
        {
            // Arrange
            var left = new ValueNode(true);
            var right = new ValueNode(false);
            var orNode = new OrNode(left, right);

            // Act
            var result = orNode.Evaluate();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void OrNode_Evaluate_LeftFalseRightTrue_ReturnsTrue_Test()
        {
            // Arrange
            var left = new ValueNode(false);
            var right = new ValueNode(true);
            var orNode = new OrNode(left, right);

            // Act
            var result = orNode.Evaluate();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void OrNode_Evaluate_BothFalse_ReturnsFalse_Test()
        {
            // Arrange
            var left = new ValueNode(false);
            var right = new ValueNode(false);
            var orNode = new OrNode(left, right);

            // Act
            var result = orNode.Evaluate();

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void NotNode_Evaluate_TrueChild_ReturnsFalse_Test()
        {
            // Arrange
            var child = new ValueNode(true);
            var notNode = new NotNode(child);

            // Act
            var result = notNode.Evaluate();

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void NotNode_Evaluate_FalseChild_ReturnsTrue_Test()
        {
            // Arrange
            var child = new ValueNode(false);
            var notNode = new NotNode(child);

            // Act
            var result = notNode.Evaluate();

            // Assert
            Assert.IsTrue(result);
        }
    }
}