using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor_design_pattern_csharp
{
    public interface IAnimalVisitor<out TOut>
    {
        TOut Visit(Cat cat);
        TOut Visit(Dog dog);
    }
}
