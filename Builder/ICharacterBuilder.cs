using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICharacterBuilder
    {
        void BuildName(string name);
        void BuildClass();
        void BuildHealth();
        void BuildAttackPower();
        void BuildMana(); 
        Character GetCharacter();
    }
}
