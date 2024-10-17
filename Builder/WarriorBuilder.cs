using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class WarriorBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public void BuildName(string Name)
        {
            _character.Name = Name;
        }
        public void BuildClass()
        {
            _character.Class = "Воин";
        }

        public void BuildHealth()
        {
            _character.Health = 150;
        }

        public void BuildAttackPower()
        {
            _character.AttackPower = 50;
        }

        public void BuildMana()
        {
            _character.Mana = 0; 
        }

        public Character GetCharacter()
        {
            return _character;
        }
    }
}
