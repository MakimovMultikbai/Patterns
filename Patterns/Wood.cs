using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Wood : IMaterial
    {
        public string Name => "Дерево";
        public void DisplayProperties()
        {
            Console.WriteLine($"Название материала: {Name}");
        }
    }
}
