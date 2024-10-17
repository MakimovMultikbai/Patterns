using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public abstract class MaterialCreator
    {
        public abstract IMaterial CreateMaterial();
        public void DisplayMaterialInfo()
        {
            IMaterial material = CreateMaterial();
            material.DisplayProperties();
        }
    }
}
