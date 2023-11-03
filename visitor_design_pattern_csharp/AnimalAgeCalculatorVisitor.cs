using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_design_pattern_csharp
{
    internal class AnimalAgeCalculatorVisitor : IAnimalVisitor<int>
    {
        public int Visit(Dog dog) => CalculateAgeFrom(dog.DateOfBirth);

        public int Visit(Cat cat) => CalculateAgeFrom(cat.DateOfBirth);

        static int CalculateAgeFrom(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-age)) age--; // not sure what that is doing

            return age;
        }
    }
}
