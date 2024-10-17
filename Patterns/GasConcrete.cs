using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class GasConcrete : IMaterial
    {
        public string Name => "Газобетон";
        public void DisplayProperties()
        {
            Console.WriteLine($"Название материала: {Name}");
        }
    }
}
