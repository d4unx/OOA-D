using ex11;
namespace TestProject1
{
	public class Tests
	{
		[Test]
		public void SimpleCoffee_Cost_ShouldBe40()
		{
            // Arrange
            SimpleCoffee coffee = new();

			// Act
			int cost = coffee.GetCost();
			
            // Assert
            Assert.That(40, Is.EqualTo(cost));
		}

		[Test]
		public void SimpleCoffee_Ingredients_ShouldBeCoffee()
		{
			// Arrange
			var coffee = new SimpleCoffee();

			// Act
			var ingredients = coffee.GetIngredients();

			// Assert
			Assert.That(ingredients, Is.EqualTo("Coffee"));
		}

		[Test]
		public void SimpleCacao_Cost_ShouldBe65()
		{
			// Arrange
			var cacao = new SimpleCacao();

			// Act
			var cost = cacao.GetCost();

			// Assert
			Assert.That(cost, Is.EqualTo(65));
		}

		[Test]
		public void SimpleCacao_Ingredients_ShouldBeCacao()
		{
			// Arrange
			var cacao = new SimpleCacao();

			// Act
			var ingredients = cacao.GetIngredients();

			// Assert
			Assert.That(ingredients, Is.EqualTo("Cacao"));
		}

		[Test]
		public void SimpleChocolate_Cost_ShouldBe80()
		{
			// Arrange
			var chocolate = new SimpleChocolate();

			// Act
			var cost = chocolate.GetCost();

			// Assert
			Assert.That(cost, Is.EqualTo(80));
		}

		[Test]
		public void SimpleChocolate_Ingredients_ShouldBeChocolate()
		{
			// Arrange
			var chocolate = new SimpleChocolate();

			// Act
			var ingredients = chocolate.GetIngredients();

			// Assert
			Assert.That(ingredients, Is.EqualTo("Chocolate"));
		}

		[Test]
		public void CoffeeWithSugar_Cost_ShouldBe45()
		{
			// Arrange
			var coffee = new SimpleCoffee();
			var coffeeWithSugar = new SugarDecorator(coffee);

			// Act
			var cost = coffeeWithSugar.GetCost();

			// Assert
			Assert.That(cost, Is.EqualTo(45));
		}

		[Test]
		public void CoffeeWithSugar_Ingredients_ShouldBeCoffeeAndSugar()
		{
			// Arrange
			var coffee = new SimpleCoffee();
			var coffeeWithSugar = new SugarDecorator(coffee);

			// Act
			var ingredients = coffeeWithSugar.GetIngredients();

			// Assert
			Assert.That(ingredients, Is.EqualTo("Coffee, Sugar"));
		}

		[Test]
		public void CoffeeWithCream_Cost_ShouldBe60()
		{
			// Arrange
			var coffee = new SimpleCoffee();
			var coffeeWithCream = new CreamDecorator(coffee);

			// Act
			var cost = coffeeWithCream.GetCost();

			// Assert
			Assert.That(cost, Is.EqualTo(60));
		}

		[Test]
		public void CoffeeWithCream_Ingredients_ShouldBeCoffeeAndCream()
		{
			// Arrange
			var coffee = new SimpleCoffee();
			var coffeeWithCream = new CreamDecorator(coffee);

			// Act
			var ingredients = coffeeWithCream.GetIngredients();

			// Assert
			Assert.That(ingredients, Is.EqualTo("Coffee, Cream"));
		}

		[Test]
		public void CoffeeWithMilk_Cost_ShouldBe70()
		{
			// Arrange
			var coffee = new SimpleCoffee();
			var coffeeWithMilk = new MilkDecorator(coffee);

			// Act
			var cost = coffeeWithMilk.GetCost();

			// Assert
			Assert.That(cost, Is.EqualTo(70));
		}

		[Test]
		public void CoffeeWithMilk_Ingredients_ShouldBeCoffeeAndMilk()
		{
			// Arrange
			var coffee = new SimpleCoffee();
			var coffeeWithMilk = new MilkDecorator(coffee);

			// Act
			var ingredients = coffeeWithMilk.GetIngredients();

			// Assert
			Assert.That(ingredients, Is.EqualTo("Coffee, Milk"));
		}

		[Test]
		public void CoffeeWithSugarAndCream_Cost_ShouldBe65()
		{
			// Arrange
			var coffee = new SimpleCoffee();
			var coffeeWithSugar = new SugarDecorator(coffee);
			var coffeeWithSugarAndCream = new CreamDecorator(coffeeWithSugar);

			// Act
			var cost = coffeeWithSugarAndCream.GetCost();

			// Assert
			Assert.That(cost, Is.EqualTo(65));
		}

		[Test]
		public void CoffeeWithSugarAndCream_Ingredients_ShouldBeCoffeeSugarAndCream()
		{
			// Arrange
			var coffee = new SimpleCoffee();
			var coffeeWithSugar = new SugarDecorator(coffee);
			var coffeeWithSugarAndCream = new CreamDecorator(coffeeWithSugar);

			// Act
			var ingredients = coffeeWithSugarAndCream.GetIngredients();

			// Assert
			Assert.That(ingredients, Is.EqualTo("Coffee, Sugar, Cream"));
		}
	}
}