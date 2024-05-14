using ex11;
namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void SimpleCoffee_Cost_ShouldBe40()
        {
            SimpleCoffee coffee = new();
            int cost = coffee.GetCost();
            Assert.That(40, Is.EqualTo(cost));
        }

        [Test]
        public void SimpleCoffee_Ingredients_ShouldBeCoffee()
        {
            var coffee = new SimpleCoffee();
            var ingredients = coffee.GetIngredients();
            Assert.That(ingredients, Is.EqualTo("Coffee"));
        }

        [Test]
        public void SimpleCacao_Cost_ShouldBe65()
        {
            var cacao = new SimpleCacao();
            var cost = cacao.GetCost();
            Assert.That(cost, Is.EqualTo(65));
        }

        [Test]
        public void SimpleCacao_Ingredients_ShouldBeCacao()
        {
            var cacao = new SimpleCacao();
            var ingredients = cacao.GetIngredients();
            Assert.That(ingredients, Is.EqualTo("Cacao"));
        }

        [Test]
        public void SimpleChocolate_Cost_ShouldBe80()
        {
            var chocolate = new SimpleChocolate();
            var cost = chocolate.GetCost();
            Assert.That(cost, Is.EqualTo(80));
        }

        [Test]
        public void SimpleChocolate_Ingredients_ShouldBeChocolate()
        {
            var chocolate = new SimpleChocolate();
            var ingredients = chocolate.GetIngredients();
            Assert.That(ingredients, Is.EqualTo("Chocolate"));
        }

        [Test]
        public void CoffeeWithSugar_Cost_ShouldBe45()
        {
            var coffee = new SimpleCoffee();
            var coffeeWithSugar = new SugarDecorator(coffee);
            var cost = coffeeWithSugar.GetCost();
            Assert.That(cost, Is.EqualTo(45));
        }

        [Test]
        public void CoffeeWithSugar_Ingredients_ShouldBeCoffeeAndSugar()
        {
            var coffee = new SimpleCoffee();
            var coffeeWithSugar = new SugarDecorator(coffee);
            var ingredients = coffeeWithSugar.GetIngredients();
            Assert.That(ingredients, Is.EqualTo("Coffee, Sugar"));
        }

        [Test]
        public void CoffeeWithCream_Cost_ShouldBe60()
        {
            var coffee = new SimpleCoffee();
            var coffeeWithCream = new CreamDecorator(coffee);
            var cost = coffeeWithCream.GetCost();
            Assert.That(cost, Is.EqualTo(60));
        }

        [Test]
        public void CoffeeWithCream_Ingredients_ShouldBeCoffeeAndCream()
        {
            var coffee = new SimpleCoffee();
            var coffeeWithCream = new CreamDecorator(coffee);
            var ingredients = coffeeWithCream.GetIngredients();
            Assert.That(ingredients, Is.EqualTo("Coffee, Cream"));
        }

        [Test]
        public void CoffeeWithMilk_Cost_ShouldBe70()
        {
            var coffee = new SimpleCoffee();
            var coffeeWithMilk = new MilkDecorator(coffee);
            var cost = coffeeWithMilk.GetCost();
            Assert.That(cost, Is.EqualTo(70));
        }

        [Test]
        public void CoffeeWithMilk_Ingredients_ShouldBeCoffeeAndMilk()
        {
            var coffee = new SimpleCoffee();
            var coffeeWithMilk = new MilkDecorator(coffee);
            var ingredients = coffeeWithMilk.GetIngredients();
            Assert.That(ingredients, Is.EqualTo("Coffee, Milk"));
        }

        [Test]
        public void CoffeeWithSugarAndCream_Cost_ShouldBe65()
        {
            var coffee = new SimpleCoffee();
            var coffeeWithSugar = new SugarDecorator(coffee);
            var coffeeWithSugarAndCream = new CreamDecorator(coffeeWithSugar);
            var cost = coffeeWithSugarAndCream.GetCost();
            Assert.That(cost, Is.EqualTo(65));
        }

        [Test]
        public void CoffeeWithSugarAndCream_Ingredients_ShouldBeCoffeeSugarAndCream()
        {
            var coffee = new SimpleCoffee();
            var coffeeWithSugar = new SugarDecorator(coffee);
            var coffeeWithSugarAndCream = new CreamDecorator(coffeeWithSugar);
            var ingredients = coffeeWithSugarAndCream.GetIngredients();
            Assert.That(ingredients, Is.EqualTo("Coffee, Sugar, Cream"));
        }
    }
}
