using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CharacterDirector
    {
        private readonly ICharacterBuilder _characterBuilder;

        public CharacterDirector(ICharacterBuilder characterBuilder)
        {
            _characterBuilder = characterBuilder;
        }

        public Character BuildCharacter(string Name)
        {
            _characterBuilder.BuildName(Name);
            _characterBuilder.BuildClass();
            _characterBuilder.BuildHealth();
            _characterBuilder.BuildAttackPower();
            _characterBuilder.BuildMana();
            return _characterBuilder.GetCharacter();
        }
    }
}
