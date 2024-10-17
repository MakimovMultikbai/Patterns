using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Mana { get; set; }

        public override string ToString()
        {
            return $"Персонаж: {Name} \nКласс: {Class}, \nЗдоровье: {Health}, \nСила атаки: {AttackPower}, \nМана: {Mana}";
        }
    }
}
