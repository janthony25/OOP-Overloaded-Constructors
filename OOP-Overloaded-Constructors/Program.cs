using System;

namespace MyFirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            // ********* IMPORTANT NOTE **********
            // overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature

            Pizza pizza1 = new Pizza("bread", "ketchup", "mozarella", "Pepperoni");
            Pizza pizza2 = new Pizza("bread", "Ketchup", "Mozarella");


            Console.ReadKey();
        }
    }

    class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string toppings;

        public Pizza(string bread, string sauce, string cheese, string toppings)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.toppings = toppings;
        }

        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }

        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }

        public void PepperoniPizza()
        {
            Console.WriteLine($"Here's your pizza with {bread}, {sauce}, {cheese}, {toppings}");
        }

    }

}