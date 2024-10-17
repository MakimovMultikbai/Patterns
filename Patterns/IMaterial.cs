using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public interface IMaterial
    {
        string Name { get; }
        void DisplayProperties();
    }
}
