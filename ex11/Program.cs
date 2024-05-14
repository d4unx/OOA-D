using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{

    abstract class Coffe 
    {
        public abstract int GetCost();
        public abstract string GetIngredients();   
    }

    class SimpleCoffee : Coffe 
    {
        public override int GetCost()
        {
            return 40;
        }

        public override string GetIngredients()
        {
            return "Coffee";  
        }
    }
    class SimpleCacao : Coffe
    {
        public override int GetCost()
        {
            return 65;
        }

        public override string GetIngredients()
        {
            return "Cacao";
        }
    }
    class SimpleChocolate : Coffe
    {
        public override int GetCost()
        {
            return 80;
        }

        public override string GetIngredients()
        {
            return "Chocolate";
        }
    }
    class Decorator : Coffe 
    {
        private Coffe _coffe;
        public Decorator(Coffe cof)
        {
            this._coffe = cof;
        }
        public override int GetCost()
        {
            return _coffe.GetCost();
        }

        public override string GetIngredients()
        {
            return _coffe.GetIngredients();
        }
    }

    class SugarDecorator : Decorator
    {
        private readonly Coffe _coffee;

        public SugarDecorator(Coffe coffee) : base(coffee)
        {
            _coffee = coffee;
        }

        public override int GetCost()
        {
            return _coffee.GetCost() + 5;
        }

        public override string GetIngredients()
        {
            return _coffee.GetIngredients() + ", Sugar";
        }
       
    }
    class CreamDecorator : Decorator
    {
        private readonly Coffe _coffee;

        public CreamDecorator(Coffe coffee): base(coffee)
        {
            _coffee = coffee;
        }

        public override int GetCost()
        {
            return _coffee.GetCost() + 20;
        }

        public override string GetIngredients()
        {
            return _coffee.GetIngredients() + ", Cream";
        }
    }
    class MilkDecorator : Decorator
    {
        private readonly Coffe _coffee;

        public MilkDecorator(Coffe coffee) : base(coffee)
        {
            _coffee = coffee;
        }

        public override int GetCost()
        {
            return _coffee.GetCost() + 30;
        }

        public override string GetIngredients()
        {
            return _coffee.GetIngredients() + ", Milk";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Кофе - 40 Какао - 65 ШоколаД - 80
            // Сахар - 5 Сливки - 20 Молоко - 30
            Coffe coffee = new SimpleCoffee();
            Console.WriteLine(coffee.GetCost());  
            Console.WriteLine(coffee.GetIngredients());
            Console.WriteLine("------------------------------");
            coffee = new SugarDecorator(coffee);
            Console.WriteLine(coffee.GetCost());  
            Console.WriteLine(coffee.GetIngredients());
            Console.WriteLine("------------------------------");
            Coffe choch = new SimpleChocolate();
            choch = new SugarDecorator(choch);
            choch = new CreamDecorator(choch);
            choch = new MilkDecorator(choch);
            Console.WriteLine(choch.GetCost());
            Console.WriteLine(choch.GetIngredients());
            Console.WriteLine("------------------------------");
            Coffe cof = new SimpleCacao();
            cof = new SugarDecorator(cof);
            cof = new CreamDecorator(cof);
            Console.WriteLine(cof.GetCost());
            Console.WriteLine(cof.GetIngredients());
        }
    }
}
