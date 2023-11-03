using System.Xml.Linq;

namespace visitor_design_pattern_csharp
{
    public abstract class Animal
    {
        public readonly string Name;
        public readonly DateTime DateOfBirth;

        public Animal(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public abstract string Speak();
        public abstract T Accept<T>(IAnimalVisitor<T> visitor);
    }

    public class Dog : Animal
    {
        public Dog(string name, DateTime dateOfBirth)
            : base(name, dateOfBirth)
        {
        }

        public override string Speak() => "Woof";

        public override T Accept<T>(IAnimalVisitor<T> visitor)
            => visitor.Visit(this);
    }

    public class Cat : Animal
    {
        public Cat(string name, DateTime dateOfBirth)
            : base(name, dateOfBirth)
        {
        }

        public override string Speak() => "Miaow";

        public override T Accept<T>(IAnimalVisitor<T> visitor)
            => visitor.Visit(this);
    }
}