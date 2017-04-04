using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Extended.Specialties;

namespace ArmyOfCreatures.Extended.Creatures
{
    public class WolfRaider : Creature
    {
        public WolfRaider() : base (8, 5, 10, 3.5m)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }




    }
}
