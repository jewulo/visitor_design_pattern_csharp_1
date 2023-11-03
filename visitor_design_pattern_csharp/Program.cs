/**
 * https://www.codurance.com/publications/a-visitor-pattern-came-knocking 
 */
namespace visitor_design_pattern_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Sasha", new DateTime(2014, 4, 1));
            Console.WriteLine($"{dog.Name} is {dog.Accept(new AnimalAgeCalculatorVisitor())} years old");
            Console.WriteLine(dog.Accept(new AnimalMakesNoiseVisitor()));

            var cat = new Cat("Sootie", new DateTime(2019, 10, 8));
            Console.WriteLine($"{cat.Name} is {cat.Accept(new AnimalAgeCalculatorVisitor())} years old");
            Console.WriteLine(cat.Accept(new AnimalMakesNoiseVisitor()));
        }
    }
}