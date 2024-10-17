using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Brick : IMaterial
    {
        public string Name => "Кирпич";
        public void DisplayProperties()
        {
            Console.WriteLine($"Название материала: {Name}");
        }
    }
}
