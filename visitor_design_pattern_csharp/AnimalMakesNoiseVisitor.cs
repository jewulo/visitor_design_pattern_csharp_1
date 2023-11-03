using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_design_pattern_csharp
{
    internal class AnimalMakesNoiseVisitor : IAnimalVisitor<string>
    {
        public string Visit(Dog dog) =>
            $"{dog.Name} the {dog.GetType().Name} goes \'{dog.Speak()!}'";

        public string Visit(Cat cat) =>
            $"{cat.Name} the {cat.GetType().Name} goes \'{cat.Speak()!}'";
    }
}
