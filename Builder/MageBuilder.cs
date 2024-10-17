using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MageBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public void BuildName(string Name)
        {
            _character.Name = Name;
        }
        public void BuildClass()
        {
            _character.Class = "Волшебник";
        }

        public void BuildHealth()
        {
            _character.Health = 100;
        }

        public void BuildAttackPower()
        {
            _character.AttackPower = 70;
        }

        public void BuildMana()
        {
            _character.Mana = 100; 
        }

        public Character GetCharacter()
        {
            return _character;
        }
    }

}
